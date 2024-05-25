--aP va a ser la abreviatura de academicPeriod
aP x = div x 100000 --Me va a devolver los datos del periodo academico
yearAcademicPeriod x = show(2000 + div (aP x) 10) --Me devuelve el año
academicPeriod x = show(rem (aP x) 10) --Me devuelve el semestre

--aPC va a ser la abreviatura de academicProgramCategory
aPC x = rem (div x 1000) 100 --Me devuelve los datos de la categoria del programa academico
crearLista x = [1..((aPC x)-1)] --Me crea la lista que despues voy a filtrar para encontrar los factores
esFactor num posFactor = rem num posFactor == 0 --Para verificar si un número es factor ("pos" es "posible")
crearListaFactores num = filter (esFactor num) --Funcion para crear la lista con los factores
listaFactores x = crearListaFactores (aPC x) (crearLista x) --Me devuelve la lista con los factores
--Los elementos de (crearLista x) son los "posFactor"
aPCOut x --Funcion para devolver la categoria del programa
    |sum (listaFactores x) == (aPC x) = " Engineering"
    |sum (listaFactores x) < (aPC x) = " Humanities"
    |otherwise = " Administrative"
    
-- cAN va a ser la abreviatura de consecutiveAdmissionNumber
cAN x = " num"++show(rem x 1000) --Me devuelve los datos del número consecutivo de admisión
isEven x --Función para determinar si el número es par o impar
    |even x = " even" -- Verifica si el número es par
    |otherwise = " odd"

main :: IO()
main = do
    a <- readLn :: IO Integer
    putStrLn $ yearAcademicPeriod a ++ "-" ++ academicPeriod a ++ aPCOut a ++ cAN a ++ isEven a