namespace gregsharp.Repositories;
public class HousesRepository
{
    private readonly IDbConnection _db;

  public HousesRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<House> Get()
  {
    string sql = @"
    SELECT
    *
    FROM
    houses;
    ";
    List<House> houses = _db.Query<House>(sql).ToList();
    return houses;
  }
  internal House Create(House houseData)
  {
    string sql = @"
    INSERT INTO houses
    (address, price, imgUrl, levels, beds, baths, garage)
    VALUES
    (@address, @price, @imgUrl, @levels, @beds, @baths, @garage);

    SELECT LAST_INSERT_ID();";
    int id = _db.ExecuteScalar<int>(sql, houseData);
    houseData.Id = id;
    return houseData;
  }
}
