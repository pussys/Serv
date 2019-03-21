using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class LandMgr
{
    public static LandMgr instance;
    public LandMgr()
    {
        instance = this;
    }
    //获取地的情况
    //协议参数
    //返回数据
    public void MsgGetLand(Player player, ProtocolBase protoBase)
    {
        ProtocolBytes protocolRet = new ProtocolBytes();
        protocolRet.AddString("GetLand");
        protocolRet.AddInt(player.data.UncultivatedLand);
        protocolRet.AddInt(player.data.Ordinary);
        protocolRet.AddInt(player.data.Gold);
        protocolRet.AddInt(player.data.Diamonds);
        player.Send(protocolRet);
        Console.WriteLine("MsgGetLand" + player.id 
            + player.data.UncultivatedLand 
            + player.data.Ordinary 
            + player.data.Gold 
            + player.data.Diamonds);
    }
    public void MsgGetNumber(Player player, ProtocolBase protoBase)
    {
        ProtocolBytes protocolRet = new ProtocolBytes();
        protocolRet.AddString("GetNumber");
        protocolRet.AddInt(player.number.maigcNum);
        protocolRet.AddInt(player.number.DiamondNum);
        player.Send(protocolRet);
        Console.WriteLine("MsgGetNumber" + player.id + player.number.maigcNum + player.number.DiamondNum);
    }
    /// <summary>
    /// 开垦普通土地
    /// </summary>
    /// <param name="player"></param>
    /// <param name="protoBase"></param>
    public void MsgOrdinary(Player player, ProtocolBase protoBase)
    {
        if (!(player.data.UncultivatedLand<=0))
        {
            player.data.UncultivatedLand -= 1;
            player.data.Ordinary += 1;
        }
    }
    /// <summary>
    /// 开垦金土地
    /// </summary>
    /// <param name="player"></param>
    /// <param name="protoBase"></param>
    public void MsgGold(Player player, ProtocolBase protoBase)
    {
        if (!(player.data.UncultivatedLand <= 0))
        {
            player.data.UncultivatedLand -= 1;
            player.data.Gold += 1;
        }
    }
    /// <summary>
    /// 开垦钻石土地
    /// </summary>
    /// <param name="player"></param>
    /// <param name="protoBase"></param>
    public void MsgDiamonds(Player player, ProtocolBase protoBase)
    {
        if (!(player.data.UncultivatedLand <= 0))
        {
            player.data.UncultivatedLand -= 1;
            player.data.Diamonds += 1;
        }
    }
    /// <summary>
    /// 普通土地升金土地
    /// </summary>
    /// <param name="player"></param>
    /// <param name="protoBase"></param>
    public void MsgOrdinaryUpGold(Player player, ProtocolBase protoBase)
    {
        player.data.Ordinary -= 1;
        player.data.Gold += 1;
    }
    /// <summary>
    /// 普通土地升钻石土地
    /// </summary>
    /// <param name="player"></param>
    /// <param name="protoBase"></param>
    public void MsgOrdinaryUpDiamonds(Player player, ProtocolBase protoBase)
    {
        player.data.Ordinary -= 1;
        player.data.Gold += 1;
    }
    /// <summary>
    /// 金土地升钻石土地
    /// </summary>
    public void MsgGoldUpDiamonds(Player player, ProtocolBase protoBase)
    {
        player.data.Gold -= 1;
        player.data.Diamonds += 1;
    }
}
