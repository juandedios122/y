# Sprint 2 — Objetivo
Objetivo: Mejorar robustez y UX; añadir comprobaciones, diagnóstico y prevención de condiciones de carrera.

Período: 1 semana

Sprint Backlog
1. Transacciones atómicas para crear reserva y marcar mesa (4 puntos) — Dev: Negocio/Data
2. Diagnóstico y mensajes útiles (2 puntos) — Dev: UI/Docs
3. Manejo de preferencias y filtro en búsqueda (2 puntos) — Dev: UI
4. Tests manuales y casos edge (3 puntos) — Dev: QA
5. Separación básica de capas (Interfaces para repositorio) (4 puntos) — Dev: Arquitectura

Definition of Done:
- Crear reserva robusta con reintentos ante conflicto.
- QA passed en casos: reservas simultáneas, preferencia "Ninguna", validaciones de datos.