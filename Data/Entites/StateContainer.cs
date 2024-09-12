namespace neighborhoodFlavors.Data;

class StateContainer
{
    public User? CurrentUser { get; set; }
    public Restaurant? CurrentRestaurant { get; set; }

    public void SetRestaurant(Restaurant restaurant)
    {
        CurrentRestaurant = restaurant;
    }
}