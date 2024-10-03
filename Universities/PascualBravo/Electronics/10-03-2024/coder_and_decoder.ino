String clave = "hola";
int a = 0;
int b = 0;
int c = 0;
String palabra = "";
bool modoCodificar = true;  // True para codificar, False para descodificar

void setup() {
    Serial.begin(9600);
    Serial.println("Ingresa la palabra para codificar:");
}

void loop() {
    if (Serial.available() > 0) {
        palabra = Serial.readString();
        a = clave.length();
        b = palabra.length() - 1;

        if (modoCodificar) {
            char pal_cod[b];  // Crear espacio para la cadena codificada

            for (int i = 0; i < b; i++) {
                c = (clave[i % a] + palabra[i] - 2 * 97) % 25 + 97;
                pal_cod[i] = char(c);
            }
            pal_cod[b] = '\0';  // Terminar la cadena con el carácter nulo
            Serial.println("Palabra codificada:");
            Serial.println(pal_cod);

            modoCodificar = false;  // Cambiar a modo de descodificar
            Serial.println("Ingresa la palabra codificada para descodificar:");
        } else {
            char pal_cod[b];
            palabra.toCharArray(pal_cod, b + 1);  // Convertir la entrada a char array
            descodificar(pal_cod, b);

            modoCodificar = true;  // Cambiar a modo de codificar
            Serial.println("Ingresa la palabra para codificar:");
        }
    }
}

void descodificar(char pal_cod[], int b) {
    char palabra_desencriptada[b];
    for (int i = 0; i < b; i++) {
        int temp = (pal_cod[i] - 97 - (clave[i % a] - 2 * 97) + 28) % 25 + 97;
        palabra_desencriptada[i] = char(temp);
    }
    palabra_desencriptada[b] = '\0';  // Terminar la cadena con un carácter nulo
    Serial.println("Palabra descodificada:");
    Serial.println(palabra_desencriptada);
}