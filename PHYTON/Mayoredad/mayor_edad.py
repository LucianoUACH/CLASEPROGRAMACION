print("INGRESE EDAD:")
EDAD = int(input()) 

if EDAD >= 0 and EDAD <= 130:
    if EDAD >= 18:
      print("mayor de edad")
    else:
      print ("menor de edad")
else:
    print("error")