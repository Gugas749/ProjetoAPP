# iTask

---------------------------------------------------------------------------------------------------
## FORMS FEITOS

frmLogin

frmGereTipoTarefas

frmDetalhesTarefa (adicionar)

frmDetalhesTarefa (detalhes) ?feito? (por testar)

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
    user.Nome = "Nome do utilizador";
    user.Username = "gest1";
    user.Password = "1";
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
        prog.Nome = "Programador Teste";
        prog.Username = "prog1";
        prog.Password = "1";
        prog.NivelExperiencia = NivelExperiencia.Junior;
        prog.IdGestor = gestor.Id;
        prog.Gestor = gestor;

        db.Utilizadores.Add(prog);
        db.SaveChanges();
    }
}
```

---------------------------------------------------------------------------------------------------
## JIRA JIRA

-- [Jira link](https://piogo10.atlassian.net/jira/software/projects/MS3C/summary)

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
