String clave = "hola";
int a = 0;
int b = 0;
int c = 0;
String palabra = "";

void setup() {
    Serial.begin(9600);
    Serial.println('2');
}

void loop() {
    if (Serial.available() > 0) {
        a = clave.length();
        palabra = Serial.readString();
        b = palabra.length() - 1;
        char pal_cod[b];  // Añadir espacio para el carácter nulo

        for (int i = 0; i < b; i++) {
            c = (clave[i % a] + palabra[i] - 2 * 97) % 25 + 97;
            pal_cod[i] = char(c);
        }
        pal_cod[b] = '\0';  // Terminar la cadena con el carácter nulo
        Serial.println(pal_cod);
        descodificar(pal_cod, b);
    }
}

void descodificar(char pal_cod[], int b) {
    char palabra_desencriptada[b];
    for (int i = 0; i < b; i++) {
        int temp = (pal_cod[i] - 97 - (clave[i % a] - 2 * 97) + 28) % 25 + 97;
        palabra_desencriptada[i] = char(temp);
    }
    palabra_desencriptada[b] = '\0';  // Terminar la cadena con un carácter nulo
    Serial.println(palabra_desencriptada);
}