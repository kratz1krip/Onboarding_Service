# АИС «Сервис онбординга сотрудников»

Система ведет чек-листы адаптации для новых сотрудников, назначает им наставников и проводит тестирование знаний.

## Структура репозитория

| Каталог | Содержимое |
|---|---|
| `src/Onboarding.Core` | доменная модель: чек-листы, задачи адаптации, наставники, тесты |
| `src/Onboarding.Infrastructure` | хранение данных через EF Core, связь с кадровой базой |
| `src/Onboarding.UI` | приложение новичка и наставника |
| `tests/Onboarding.Tests` | модульные тесты xUnit |
| `docs/architecture` | ER-схема, записи архитектурных решений (ADR) |
| `docs/openapi` | спецификация API сервиса |

## Паспорт артефактов

| Категория | Артефакт | Где лежит |
|---|---|---|
| Архитектурный | ER-схема БД онбординга (Employee, Mentor, ChecklistTemplate, ChecklistTask, Quiz, QuizAttempt) | `docs/architecture/er-onboarding.puml` |
| Контрактный | OpenAPI-спецификация Onboarding.Checklists API | `docs/openapi/onboarding-checklists.yaml` |
| Кодовой / тестовый | xUnit-тест `MentorAssignmentServiceTests.Assign_WhenMentorHasThreeNewcomers_ThrowsLimitExceeded` | `tests/Onboarding.Tests` |
| Управленческий | Карточка дефекта ONB-112 «Новичок видит задачи чек-листа чужого отдела» | `docs/defects/ONB-112.md` |

Правила работы с репозиторием – в [CONTRIBUTING.md](CONTRIBUTING.md), архитектурные решения – в `docs/architecture/adr`.
