import Data.Char (digitToInt)
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
    | isAbundant n = "Administratives"
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
    print $ studentCodeCharacteristics 24276002 -- "2024-2 Humanities num2 even"
    print $ studentCodeCharacteristics 25128112 -- "2025-1 Engineering num112 even"
    print $ studentCodeCharacteristics 25206025 -- "2025-2 Engineering num25 odd"
    print $ studentCodeCharacteristics 26124236 -- "2026-1 Administratives num236 even"
    print $ studentCodeCharacteristics 26299115 -- "2026-2 Humanities num115 odd"