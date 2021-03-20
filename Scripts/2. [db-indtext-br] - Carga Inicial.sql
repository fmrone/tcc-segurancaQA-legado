-- carga na tabela Cheklist
DELETE ChecklistNorma
DELETE Norma
DELETE Checklist

INSERT Checklist (Responsavel, Area, RealizadoEm, Observacao)
SELECT 'Frederico Ribeiro', 1, null, 'Cheklist industrial' UNION ALL
SELECT 'Frederico Ribeiro', 1, '2021-03-19 10:00', 'Cheklist industrial realizado' UNION ALL
SELECT 'Frederico Ribeiro', 2, null, 'Cheklist ambiental' UNION ALL
SELECT 'Frederico Ribeiro', 2, '2021-03-19 13:00', 'Cheklist ambiental realizado'

INSERT Norma (Descricao, Codigo, Area, [Status])
SELECT 'NR-5 – Comissão Interna de Prevenção de Acidentes', 'NR-5', 1, 1 UNION ALL
SELECT 'NR-6 – Equipamento de Proteção Individual (EPI)', 'NR-6', 1, 1 UNION ALL
SELECT 'NR-10 – Segurança em Instalações e Serviços em Eletricidade', 'NR-10', 1, 1 UNION ALL
SELECT 'NR-12 – Segurança no Trabalho em Máquinas e Equipamentos', 'NR-12', 1, 1 UNION ALL
SELECT 'Tratamento do Descarte de Tecidos', 'NR-15', 2, 1

-- Vincula cheklists e normas aos chekilist finalizados
-- IMPORTANE 
--> RF - As normas "novas" que chegarem através da integração com o SIGGO será vinculadas apenas nos cheklists em aberto

INSERT ChecklistNorma (ChecklistId, NormaId, Atendido)
SELECT c.Id, n.Id, CASE ISNULL(c.RealizadoEm, 0) WHEN 0 THEN 0 ELSE 1 END
  FROM Checklist c 
       inner join Norma n on (c.Area = n.Area)
 WHERE N.[Status] = 1 
 ORDER BY n.Area

SELECT * FROM Checklist
SELECT * FROM Norma
SELECT * FROM ChecklistNorma



