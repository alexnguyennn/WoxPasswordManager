using PasswordManager.Providers.Models;

namespace PasswordManager.Contract
{
    interface IPasswordProvider
    {
        void Login();
        Record QueryRecordFromVault(string key);
        void SetRecordInVault(Record record);

    } 
}
