# Guion de la demo (15 minutos)

0. Introducción (1 min)
   - Equipo y roles.
   - Cliente real y problema: gestión manual de reservas; errores y solapamientos.

1. Resumen Scrum (2 min)
   - Mostrar Product Backlog y objetivos de 3 sprints.
   - Mostrar SPRINT1/2/3 con lo conseguido.

2. Demo funcional (8 min)
   - Levantar la base de datos (ejecutar `scripts/create_schema.sql`).
   - Abrir la aplicación (FormPrincipal).
   - Mostrar grid con reservas (vacío o con datos).
   - Crear una nueva reserva: rellenar datos, comprobar disponibilidad, confirmar.
   - Mostrar que la reserva aparece en el grid.
   - Simular no-show: esperar timer (o forzar estado) y mostrar liberación de mesa.

3. Q&A técnica (3 min)
   - Arquitectura: capa UI / servicio `Restaurante` / `DBHelper`.
   - Transacción atómica al crear reserva.
   - Qué queda por mejorar (tests, API, logging).

4. Cierre (1 min)
   - Próximos pasos y entrega de artefactos en el repositorio.