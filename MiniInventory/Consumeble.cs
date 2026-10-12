using System;
using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace MiniInventory;

public class Consumeble : Item
{
    public int UsesMax;
    public int UsesCurrent;

    public void use(Character target)
    {
        
    }
}
