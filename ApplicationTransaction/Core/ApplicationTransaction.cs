using AppTransaction.SharedModels;
using AppTransaction.Service;

namespace AppTransaction.Core;

public class ApplicationTransaction
{
    private User[] Users;

    public ApplicationTransaction()
    {
        Users = new User[4] {
            new User(1234, "test1", "s2345678", "liubasokolovskaya@gmail.com"),
            new User(34567, "test2", "sasgff234", "liuba@gmail.com"),
            new User(98765, "test3", "sdsf654", "sokolovskaya@gmail.com"),
            new User(345678, "test4", "sdf56a5", "myname@gmail.com"),
        };
    }
    public void SignIn()
    {
        Account authorization = new Account();
          if (authorization.Login(Users, out User? user))
        {
            WorkflowTransaction workflowTransactions = new WorkflowTransaction();
            workflowTransactions.Show(user);
        }
    }
}