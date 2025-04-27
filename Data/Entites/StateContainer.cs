namespace neighborhoodFlavors.Data;

class StateContainer
{
    public User? CurrentUser { get; set; }
    public Restaurant? CurrentRestaurant { get; set; }
    public Boolean Authenticated { get; set; } = false;

    public void SetRestaurant(Restaurant restaurant)
    {
        CurrentRestaurant = restaurant;
    }

    public Boolean Login()
    {
        Authenticated = true;
        return Authenticated;
    }

    public Boolean Logout()
    {
        Authenticated = false;
        return Authenticated;
    }
}