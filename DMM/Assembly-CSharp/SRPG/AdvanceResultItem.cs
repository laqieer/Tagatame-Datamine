// Decompiled with JetBrains decompiler
// Type: SRPG.AdvanceResultItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C60")]
  [AddComponentMenu("Battle/BattleUI/AdvanceResultItem")]
  public class AdvanceResultItem : MonoBehaviour
  {
    [Token(Token = "0x4002140")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextRewardName;
    [Token(Token = "0x4002141")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TextRewardNum;
    [Token(Token = "0x4002142")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject TextRewardConn;
    [Token(Token = "0x4002143")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    [Space(5f)]
    private AdvanceRewardIcon RewardIconTemplate;
    [Token(Token = "0x4002144")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Transform TrRewardIconParent;
    [Token(Token = "0x4002145")]
    [FieldOffset(Offset = "0x20")]
    private int mIndex;
    [Token(Token = "0x4002146")]
    [FieldOffset(Offset = "0x24")]
    private GiftData mGiftData;

    [Token(Token = "0x170002E7")]
    public int Index
    {
      [Token(Token = "0x60030C4"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170002E8")]
    public GiftData GiftData
    {
      [Token(Token = "0x60030C5"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (GiftData) null;
      }
    }

    [Token(Token = "0x60030C6")]
    [Address(RVA = "0x101CE10", Offset = "0x101BC10", VA = "0x1101CE10")]
    public void SetItem(int index, GiftData gift)
    {
    }

    [Token(Token = "0x60030C7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdvanceResultItem()
    {
    }
  }
}
