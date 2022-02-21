using WebAPI2.Models;
namespace WebAPI2.Services
{
    public class PersonService : IPerson
    {
         public static List<PersonModel> listPerson = new List<PersonModel>{
             new PersonModel{
                 ID=1,
                FirstName = "Dinh Quan",
                LastName = "Pham",
                DateOfBirth = new DateTime(2000, 02, 24),
                Gender = "Male",
                BirthPlace = "Thai Binh"
            },
             new PersonModel{
                 ID = 2,
                FirstName = "Hong Lieu",
                LastName = "Dao Thi",
                DateOfBirth = new DateTime(2001, 06, 22),
                Gender = "FeMale",
                BirthPlace = "Thai Binh"
            },
             new PersonModel{
                 ID = 3,
                FirstName = "Dinh Phong",
                LastName = "Pham",
                DateOfBirth = new DateTime(2000, 02, 24),
                Gender = "Male",
                BirthPlace = "Nam Dinh"
            },
            new PersonModel{
                 ID = 4,
                FirstName = "Quynh Anh",
                LastName = "Pham",
                DateOfBirth = new DateTime(2005, 03, 10),
                Gender = "FeMale",
                BirthPlace = "Ha Noi"
            },
            new PersonModel{
                 ID = 5,
                FirstName = "Thanh Long",
                LastName = "Phan",
                DateOfBirth = new DateTime(1994, 08, 12),
                Gender = "Male",
                BirthPlace = "Hung Yen"
            },
            new PersonModel{
                 ID = 6,
                FirstName = "Thi Linh",
                LastName = "Tran",
                DateOfBirth = new DateTime(1999, 11, 09),
                Gender = "FeMale",
                BirthPlace = "Bac Giang"
            }
         };
         public List<PersonModel> GetAll(){
             return listPerson;
         }
         public void Create(PersonModel per){
             listPerson.Add(per);
         }
         public void Update(PersonModel per){
             var taskUpdate = listPerson.Where(x=>x.ID==per.ID).FirstOrDefault();
             taskUpdate.ID = per.ID;
             taskUpdate.FirstName = per.FirstName;
             taskUpdate.LastName = per.LastName;
             taskUpdate.DateOfBirth = per.DateOfBirth;
             taskUpdate.Gender = per.Gender;
             taskUpdate.BirthPlace = per.BirthPlace;
         }
         public void Delete(int id){
             var taskDelete = listPerson.Where(x=>x.ID == id).FirstOrDefault();
             listPerson.Remove(taskDelete);
         }
        public List<PersonModel> GetFullname(string firstname,string lastName,string gender,string birthplace){
            var getfn = listPerson.Where(x=>x.FirstName==firstname).Where(p=>p.LastName ==lastName)
            .Where(q=>q.Gender ==gender).Where(v=>v.BirthPlace ==birthplace).ToList();
           
            return getfn;
        }
              
         
    }
}