---------------------------------------------------------------------------------------------------
FORMS FEITOS

frmLogin

frmGereTipoTarefas

frmDetalhesTarefa (adicionar)

frmDetalhesTarefa (detalhes) ?feito? (por testar)

---------------------------------------------------------------------------------------------------
DESIGN

84;95;113  -  butao

89;98;116  -  texto

108;118;132  -  borda text box

---------------------------------------------------------------------------------------------------
CODIGOS

using (var db = new DBContext())
{
    Gestor user = new Gestor();
    user.Nome = "Nome do utilizador";
    user.Password = "1";
    user.Username = "gest1";
    user.GereUtilizadores = true;
    user.Departamento = Departamento.Administracao;
    db.Utilizadores.Add(user);
    db.SaveChanges();
}

---------------------------------------------------------------------------------------------------
JIRA JIRA

https://piogo10.atlassian.net/jira/software/projects/MS3C/summary

---------------------------------------------------------------------------------------------------
LOGINS

gest1
1

---------------------------------------------------------------------------------------------------
CONTROLADORES

INSERT

UPDATE

DELETE

---------------------------------------------------------------------------------------------------
USER ROLES

1 - Programador

2 - Gestor

---------------------------------------------------------------------------------------------------
ADICIONADO

campo titulo no model tarefa

botao delete no frmGereUtilizadores
