using WebAPI2.Models;
namespace WebAPI2.Services{
    public interface IPerson{
        List<PersonModel> GetAll();
        public void Create(PersonModel per);
        public void Update(PersonModel per);
        public void Delete(int id);
        
       public List<PersonModel> GetFullname(string firstname,string lastName,string gender,string birthplace);
       
    }
}