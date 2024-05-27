# ISBNchecker.hs

## Descripción del Proyecto

Este proyecto consiste en la creación de un programa en Haskell para identificar las características de los códigos de inscripción de los estudiantes de pregrado en la Universidad EAFIT. El objetivo es analizar y desglosar los códigos de inscripción en sus componentes principales y proporcionar información relevante sobre cada uno.

## Problema

Los empleados de la oficina de Admisiones y Registro de la Universidad EAFIT necesitan modificar la manera en que se genera el código de inscripción que se registra en la tarjeta de identificación del estudiante. Este código debe identificar:

- El período de admisión.
- El tipo de programa al que el estudiante ingresa (Administración, Humanidades o Ingeniería).
- Un número consecutivo que refleje el orden de admisión al programa.
- Indicar si el código es un valor numérico par o impar.

## Solución

La propuesta adoptada consiste en componer el código del estudiante con los siguientes elementos:

1. Los primeros tres dígitos corresponden al período de admisión (ej. 241 para 2024-1, 242 para 2024-2, etc.).
2. Los siguientes dos dígitos corresponden a la categoría del programa académico, utilizando el esquema de clasificación de Nicomachus (abundante, perfecto, deficiente).
3. Los últimos tres dígitos corresponden al número consecutivo de admisión, con valores de 001 a 999.
4. El código se analiza para determinar si es un valor numérico par o impar.

## Implementación

El programa está implementado en Haskell y realiza las siguientes tareas:

1. Extrae los componentes del código de inscripción.
2. Determina el período académico basado en los primeros tres dígitos.
3. Clasifica la categoría del programa académico utilizando la suma alícuota y el esquema de clasificación de Nicomachus.
4. Obtiene el número consecutivo de admisión.
5. Determina si el código es par o impar.
6. Genera la salida esperada en el formato especificado.

### Código

```haskell
import Text.Printf (printf)

-- Función principal que toma un código y retorna sus características
studentCodeCharacteristics :: Int -> String
studentCodeCharacteristics code = 
    let codeStr = printf "%08d" code
        period = getPeriod (take 3 codeStr)
        categoryCode = read (take 2 (drop 3 codeStr)) :: Int
        consecutive = getConsecutive (drop 5 codeStr)
        category = getCategory categoryCode
        parity = getParity code
    in period ++ " " ++ category ++ " " ++ consecutive ++ " " ++ parity

-- Función para obtener el período académico
getPeriod :: String -> String
getPeriod "241" = "2024-1"
getPeriod "242" = "2024-2"
getPeriod "251" = "2025-1"
getPeriod "252" = "2025-2"
getPeriod "261" = "2026-1"
getPeriod "262" = "2026-2"
getPeriod _ = "Unknown"

-- Función para obtener el consecutivo de admisión
getConsecutive :: String -> String
getConsecutive digits = "num" ++ show (read digits :: Int)

-- Función para determinar la categoría del programa
getCategory :: Int -> String
getCategory n
    | isAbundant n = "Administrative"
    | isPerfect n = "Engineering"
    | isDeficient n = "Humanities"
    | otherwise = "Unknown"

-- Función para verificar si un número es abundante
isAbundant :: Int -> Bool
isAbundant n = aliquotSum n > n

-- Función para verificar si un número es perfecto
isPerfect :: Int -> Bool
isPerfect n = aliquotSum n == n

-- Función para verificar si un número es deficiente
isDeficient :: Int -> Bool
isDeficient n = aliquotSum n < n

-- Función para calcular la suma alícuota
aliquotSum :: Int -> Int
aliquotSum n = sum [x | x <- [1..n-1], n `mod` x == 0]

-- Función para determinar si un número es par o impar
getParity :: Int -> String
getParity n 
    | even n = "even"
    | otherwise = "odd"

-- Ejemplos de uso
main :: IO ()
main = do
    a <- readLn
    putStrLn (studentCodeCharacteristics a)
```

### Cómo usar

1. Clona este repositorio.
2. Compila el archivo `ISBNchecker.hs` usando GHC o cualquier otro compilador de Haskell.
3. Ejecuta el programa e ingresa un código de inscripción de 8 dígitos para obtener las características del código.

## Contribuciones

Las contribuciones son bienvenidas. Por favor, crea un fork del repositorio, realiza tus cambios y envía un pull request.

## Licencia

Este proyecto está bajo la Licencia MIT.
