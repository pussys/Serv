using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Land
{
    public enum Starus
    {
        Uncultivated,//未开垦
        Gold,//金地
        Diamonds,//钻石地
        Ordinary//普通地
    }
    public Starus starus;
    public Land()
    {
        starus = Starus.Uncultivated;
    }
    /// <summary>
    /// 开垦前判断土地是不是为未开垦状态
    /// </summary>
    /// <returns></returns>
    public bool JudgeUncultivated()
    {
        if (starus == Starus.Uncultivated)
            return true;
        return false;
    }
    /// <summary>
    /// 开垦普通土地
    /// </summary>
    public void Ordinary()
    {
        starus = Starus.Ordinary;
    }
    /// <summary>
    /// 开垦金地
    /// </summary>
    public void Gold()
    {
        starus = Starus.Gold;
    }
    /// <summary>
    /// 开垦钻石地
    /// </summary>
    public void Diamonds()
    {
        starus = Starus.Diamonds;
    }
    /// <summary>
    /// 种植前判断土地是不是开垦状态
    /// </summary>
    /// <returns></returns>
    public bool JudgeReclamation()
    {
        if (starus != Starus.Uncultivated)
            return true;
        return false;
    }
    
}

