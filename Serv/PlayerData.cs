using System;

[Serializable]
public class PlayerData
{
    public int UncultivatedLand = 0;//未开垦
    public int Ordinary = 0;//普通地
    public int Gold=0;//金地
    public int Diamonds=0;//钻石地
    
    public PlayerData()
    {
        UncultivatedLand = 13;
        Gold = 1;
        Diamonds = 0;
        Ordinary = 2;
    }
}
