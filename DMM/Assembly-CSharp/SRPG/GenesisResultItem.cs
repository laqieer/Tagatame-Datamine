// Decompiled with JetBrains decompiler
// Type: SRPG.GenesisResultItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C63")]
  [AddComponentMenu("Battle/BattleUI/GenesisResultItem")]
  public class GenesisResultItem : MonoBehaviour
  {
    [Token(Token = "0x400215E")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextRewardName;
    [Token(Token = "0x400215F")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TextRewardNum;
    [Token(Token = "0x4002160")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject TextRewardConn;
    [Token(Token = "0x4002161")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [SerializeField]
    private GenesisRewardIcon RewardIconTemplate;
    [Token(Token = "0x4002162")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform TrRewardIconParent;
    [Token(Token = "0x4002163")]
    [FieldOffset(Offset = "0x20")]
    private int mIndex;
    [Token(Token = "0x4002164")]
    [FieldOffset(Offset = "0x24")]
    private GiftData mGiftData;

    [Token(Token = "0x170002EB")]
    public int Index
    {
      [Token(Token = "0x60030D6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002EC")]
    public GiftData GiftData
    {
      [Token(Token = "0x60030D7"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (GiftData) null;
      }
    }

    [Token(Token = "0x60030D8")]
    [Address(RVA = "0x1021770", Offset = "0x1020570", VA = "0x11021770")]
    public void SetItem(int index, GiftData gift)
    {
    }

    [Token(Token = "0x60030D9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public GenesisResultItem()
    {
    }
  }
}
