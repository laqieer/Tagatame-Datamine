// Decompiled with JetBrains decompiler
// Type: SRPG.MultiPlayVersusRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002794")]
  [FlowNode.Pin(0, "Refresh", FlowNode.PinTypes.Input, 0)]
  [AddComponentMenu("UI/MultiPlayVersusRanking")]
  public class MultiPlayVersusRanking : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BAED")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x400BAEE")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text RankText;
    [Token(Token = "0x400BAEF")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text BestRankText;
    [Token(Token = "0x400BAF0")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Transform IconHolder;
    [Token(Token = "0x400BAF1")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject ItemIcon;
    [Token(Token = "0x400BAF2")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject CoinIcon;
    [Token(Token = "0x400BAF3")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject GoldIcon;
    [Token(Token = "0x400BAF4")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject ArenaCoinIcon;

    [Token(Token = "0x600B194")]
    [Address(RVA = "0x75A490", Offset = "0x759290", VA = "0x1075A490", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B195")]
    [Address(RVA = "0x75A4B0", Offset = "0x7592B0", VA = "0x1075A4B0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600B196")]
    [Address(RVA = "0x75A5E0", Offset = "0x7593E0", VA = "0x1075A5E0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600B197")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MultiPlayVersusRanking()
    {
    }
  }
}
