# Sprint 1 — Objetivo
Objetivo: Entregar la mínima funcionalidad end-to-end para crear y visualizar reservas desde la UI con persistencia en BD.

Período: 1 semana

Sprint Backlog (priorizado)
1. Configurar esquema de BD y datos de ejemplo (2 puntos) — Dev: DB
   - Script `scripts/create_schema.sql` y `scripts/seed_data.sql`
   - Verificación: la app se conecta y lista mesas
2. Interfaz básica: FormPrincipal con DataGridView (3 puntos) — Dev: UI
   - Mostrar reservas, botón "Nueva Reserva"
3. Formulario de creación de reserva (3 puntos) — Dev: UI/Negocio
   - Validaciones básicas, comprobar disponibilidad
4. Lógica de negocio: asignación de mesa (4 puntos) — Dev: Negocio
   - Evitar solapamientos básicos (duración por defecto)
5. Integración de datos: insertar cliente y reserva (3 puntos) — Dev: Data Access
   - Insertar dentro de transacción
6. Documentación mínima y demo (2 puntos) — Dev: Docs
   - `DEMO_SCRIPT.md` y Product Backlog actualizado

Definition of Done:
- Código compilable.
- Script DB ejecutado y datos de prueba visibles.
- Demo funcional de crear y listar reserva.