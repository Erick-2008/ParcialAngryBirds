# Angry Birds

## Descripción

Este proyecto implementa una simulación del universo de **Angry Birds** utilizando **Programación Orientada a Objetos (POO)** en C#.

Se modelan los distintos tipos de pájaros, eventos que afectan su comportamiento, y la interacción con los obstáculos de la isla de los cerditos.

El objetivo principal es aplicar conceptos como:

* Herencia
* Polimorfismo
* Encapsulamiento
* Interfaces
* Composición
* Principios SOLID

---

## Modelo del Dominio

El sistema se divide en los siguientes componentes principales:

### Pájaros

* Existe una clase abstracta `Pajaro` que define comportamiento común.
* Cada tipo de pájaro redefine su forma de calcular la fuerza:

  * `PajaroComun`: fuerza = ira * 2
  * `Red`: depende de la cantidad de veces que se enojó
  * `Bomb`: tiene un tope de fuerza
  * `Chuck`: depende de la velocidad
  * `Terence`: similar a Red pero con multiplicador configurable
  * `Matilda`: suma la fuerza de sus huevos

---

### Huevos

* Clase `Huevo`
* La fuerza de un huevo es igual a su peso
* Utilizado por `Matilda` (composición)

---

### Islas (Dominios)

#### IslaPajaro

* Contiene una lista de pájaros
* Permite:

  * Obtener pájaros fuertes
  * Calcular fuerza total
  * Aplicar eventos
  * Atacar la isla cerdito

#### IslaCerdito

* Contiene obstáculos
* Recibe ataques de pájaros
* Permite verificar si fue despejada

---

### Eventos

Se modelan mediante una interfaz `IEvento`.

Tipos de eventos:

* `SesionIra`: reduce la ira de los pájaros (excepto Chuck)
* `InvasionCerditos`: enoja a los pájaros según cantidad de invasores
* `FiestaSorpresa`: enoja solo a los homenajeados
* `SerieEventos`: ejecuta múltiples eventos en secuencia

---

### Obstáculos

Se modelan mediante la interfaz `IObstaculo`.

Tipos:

* Paredes:

  * `Vidrio`
  * `Madera`
  * `Piedra`
* Cerditos:

  * `CerditoObrero`
  * `CerditoCasco`

Cada uno define su propia resistencia.

---

## Lógica de Combate

* Los pájaros atacan en orden
* Cada uno impacta contra el primer obstáculo
* Si su fuerza supera la resistencia:

  * El obstáculo es destruido
* Si no:

  * El obstáculo permanece

---

## Estructura del Proyecto

```
AngryBirds
│
├── doc (Diagrama de Clases del Proyecto)
├── Entidades
├── Interfaces
```

---

## Funcionalidades Implementadas

* Calcular fuerza de cualquier pájaro
* Manejar estados de ira
* Filtrar pájaros fuertes (> 50)
* Calcular fuerza total de la isla
* Aplicar eventos dinámicamente
* Simular ataques contra obstáculos
* Verificar si los huevos fueron recuperados

---

## Extensibilidad

El sistema está diseñado para permitir agregar nuevas funcionalidades sin modificar código existente.

Por ejemplo, para agregar un nuevo pájaro:

```csharp
public class PajaroNuevo : Pajaro
{
    public override int Fuerza()
    {
        // nueva lógica
    }
}
```

Esto es posible gracias a:

* Polimorfismo
* Principio Open/Closed

---

## Conceptos Aplicados

* **Herencia**: jerarquía de pájaros
* **Polimorfismo**: cálculo de fuerza dinámico
* **Interfaces**: eventos y obstáculos
* **Composición**: Matilda y sus huevos
* **Encapsulamiento**: control de estado interno
* **SOLID**:

  * Open/Closed Principle
  * Single Responsibility Principle

---

## Autor

Proyecto desarrollado como práctica de modelado orientado a objetos en C# por Eric Aguirre de 6°7
