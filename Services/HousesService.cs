namespace gregsharp.Services;
public class HousesService
{
    private readonly HousesRepository _repo;

    public HousesService(HousesRepository repo)
    {
        _repo = repo;
    }

  internal House Create(House houseData)
  {
    House house = _repo.Create(houseData);
    return house;
  }

  internal List<House> Get(){
    List<House> houses = _repo.Get();
    return houses;
  }
}
