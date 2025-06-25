# iTask

---------------------------------------------------------------------------------------------------
## FORMS FEITOS

frmLogin

frmKanban

frmGereUtilizadores

frmGereTipoTarefas

frmDetalhesTarefa (adicionar)

frmDetalhesTarefa (detalhes)

frmConsultarTarefasConcluidas

frmConsultarTarefasEmCurso

---------------------------------------------------------------------------------------------------
## DESIGN

84;95;113  -  butao

89;98;116  -  texto

108;118;132  -  borda text box

---------------------------------------------------------------------------------------------------
## CODIGOS

Adicionar Gestor:
```
using (var db = new DBContext())
{
    Gestor user = new Gestor();
    user.Nome = CaesarCipher.Encrypt("Padre", 10);
    user.Username = CaesarCipher.Encrypt("gest1", 10);
    user.Password = CaesarCipher.Encrypt("1", 10);
    user.GereUtilizadores = true;
    user.Departamento = Departamento.Administracao;
    db.Utilizadores.Add(user);
    db.SaveChanges();
}
```

Adicionar Programador:
```
using (var db = new DBContext())
{
    var gestor = db.Utilizadores.OfType<Gestor>().FirstOrDefault(g => g.Username == "gest1");

    if (gestor != null)
    {
        Programador prog = new Programador();
        prog.Nome = CaesarCipher.Encrypt("prog1", 10);
        prog.Username = CaesarCipher.Encrypt("prog1", 10);
        prog.Password = CaesarCipher.Encrypt("1", 10);
        prog.NivelExperiencia = NivelExperiencia.Junior;
        prog.IdGestor = gestor.Id;
        prog.Gestor = gestor;

        db.Utilizadores.Add(prog);
        db.SaveChanges();
    }
}
```

Dados Utilizadores:
```
SET IDENTITY_INSERT [dbo].[Utilizadors] ON
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (1, N'Padre', N'gest1', N'1', 2, 1, NULL, NULL, N'Gestor', NULL)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (2, N'Joao', N'gest2', N'1', 2, 1, NULL, NULL, N'Gestor', NULL)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (3, N'Pedro', N'gest3', N'1', 2, 0, NULL, NULL, N'Gestor', NULL)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (4, N'Diogo', N'gest2', N'1', 0, 1, NULL, NULL, N'Gestor', NULL)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (7, N'Gui', N'gest3', N'123', 0, 1, NULL, NULL, N'Gestor', NULL)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (8, N'Mariquinhas', N'gest2', N'1', 0, 1, NULL, NULL, N'Gestor', NULL)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (9, N'Joaquim3', N'gest3', N'1', 2, 0, NULL, NULL, N'Gestor', NULL)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (10, N'prog1', N'prog1', N'1', NULL, NULL, 0, 9, N'Programador', 1)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (11, N'prog2', N'prog2', N'1', NULL, NULL, 1, 4, N'Programador', 2)
INSERT INTO [dbo].[Utilizadors] ([Id], [Nome], [Username], [Password], [Departamento], [GereUtilizadores], [NivelExperiencia], [IdGestor], [Discriminator], [Gestor_Id]) VALUES (12, N'prog3', N'prog3', N'1', NULL, NULL, 1, 1, N'Programador', 3)
SET IDENTITY_INSERT [dbo].[Utilizadors] OFF
```

Dados Tarefas:
```
ControllerDetalhesTarefa controller = new ControllerDetalhesTarefa();

for (int i = 0; i < 16; i++)
{
    Tarefa tarefa = new Tarefa();
    tarefa.Titulo = "Titulo " + i;
    tarefa.IdGestor = 1;
    tarefa.IdProgramador = 10;
    tarefa.OrdemExecucao = i;
    tarefa.Descricao = "Descricao " + i;
    tarefa.DataPrevistaInicio = DateTime.Now;
    tarefa.DataPrevistaFim = DateTime.Now;
    tarefa.IdTipoTarefa = 1;
    tarefa.StoryPoints = i;
    tarefa.DataRealInicio = DateTime.Now;
    tarefa.DataRealFim = DateTime.Now;
    tarefa.DataCriacao = DateTime.Now;
    tarefa.EstadoAtual = EstadoAtual.ToDo;

    controller.saveData(tarefa);
}
```
---------------------------------------------------------------------------------------------------
## JIRA JIRA

- [Jira link](https://piogo10.atlassian.net/jira/software/projects/MS3C/summary)

---------------------------------------------------------------------------------------------------
## LOGINS
Gestores:
```
gest1
1
```
```
gest2
1
```
```
gest3
1
```
Programadores:
```
prog1
1
```
```
prog2
1
```
---------------------------------------------------------------------------------------------------
## CONTROLADORES

INSERT

UPDATE

DELETE

---------------------------------------------------------------------------------------------------
## USER ROLES

1 - Programador

2 - Gestor

---------------------------------------------------------------------------------------------------
## ADICIONADO

- Campo titulo no model tarefa
- Botao delete no frmGereUtilizadores
