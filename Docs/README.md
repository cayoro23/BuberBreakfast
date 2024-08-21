# API de desayuno de BuBer

- [API de desayuno de BuBer](#buber-breakfast-api)
    - [Crear desayuno](#crear-desayuno)
        - [Crear solicitud de desayuno](#crear-solicitud-de-desayuno)
        - [Crear respuesta de desayuno](#crear-respuesta-de-desayuno)
    - [Obtener desayuno](#obtener-desayuno)
        - [Obtener solicitud de desayuno](#obtener-solicitud-de-desayuno)
        - [Obtener respuesta de desayuno](#obtener-respuesta-de-desayuno)
    - [Actualizar desayuno](#actualizar-desayuno)
        - [Actualizar solicitud de desayuno](#actualizar-solicitud-de-desayuno)
        - [Actualizar respuesta de desayuno](#actualizar-respuesta-de-desayuno)
    - [Eliminar desayuno](#eliminar-desayuno)
        - [Eliminar solicitud de desayuno](#eliminar-solicitud-de-desayuno)
        - [Eliminar respuesta de desayuno](#eliminar-respuesta-de-desayuno)

## Crear Desayuno

### Crear solicitud de desayuno

```js
POST /breakfasts
```

```json
{
  "name": "Vegan Sunshine",
  "description": "Vegan everything! Join us for a healthy breakfast.",
  "startDateTime": "2022-04-08T08:00:00",
  "endDateTime": "2022-04-08T11:00:00",
  "savory": [
    "Oatmeal",
    "Avocado Toast",
    "Omelette",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ]
}
```

## Crear respuesta de desayuno

```js
201 Created
```

```js
Location: {{host}}/Breakfast/{{id}}
```

```json
{
  "id": "0000000-0000-00000000-000",
  "name": "Vegan everything",
  "description": "Vegan everything no se que mas poner",
  "startDateTime": "2022-04-08T08:00:00",
  "endDateTime": "2022-04-08T11:00:00",
  "lastModifiedDatetime": "2022-04-08T11:00:00",
  "savory": [
    "Oatmeal",
    "Avocado Toast",
    "Omelette",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ]
}
```
## Obtener desayuno

### Obtener solicitud de desayuno

```js
GET /breakfast/{{id}}
```

### Obtener respuesta de desayuno

```js
201 Created
```

```json
{
  "id": "0000000-0000-00000000-000",
  "name": "Vegan everything",
  "description": "Vegan everything no se que mas poner",
  "startDateTime": "2022-04-08T08:00:00",
  "endDateTime": "2022-04-08T11:00:00",
  "lastModifiedDatetime": "2022-04-08T11:00:00",
  "savory": [
    "Oatmeal",
    "Avocado Toast",
    "Omelette",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ]
}
```

## Actualizar Desayuno

### Actualizar Solicitud de Desayuno

```js
PUT /breakfast/{{id}}
```

```json
{
  "name": "Vegan everything",
  "description": "Vegan everything no se que mas poner",
  "startDateTime": "2022-04-08T08:00:00",
  "endDateTime": "2022-04-08T11:00:00",
  "savory": [
    "Oatmeal",
    "Avocado Toast",
    "Omelette",
    "Salad"
  ],
  "sweet": [
    "Cookie"
  ]
}
```

### Actualizar respuesta de desayuno

```js
204 No Content
```

or

```js
201 Created
```

```js
Location: {{host}}/Breakfast/{{id}}
```

## Eliminar desayuno

### Eliminar solicitud de desayuno

```js
DELETE /breakfasts/{{id}}
```

### Eliminar respuesta de desayuno

```js
204 No Content
```