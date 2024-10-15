// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureHistoryItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F99")]
  [AddComponentMenu("UI/Adventure/AdventureHistoryItem")]
  public class AdventureHistoryItem : MonoBehaviour
  {
    [Token(Token = "0x4008581")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text TextAreaName;
    [Token(Token = "0x4008582")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text TextAdvDate;
    [Token(Token = "0x4008583")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text TextAllCombatPower;
    [Token(Token = "0x4008584")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private BitmapText TextAreaLevelPrefix;
    [Token(Token = "0x4008585")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private BitmapText TextAreaLevelNum;
    [Token(Token = "0x4008586")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject GoParentUnit;
    [Token(Token = "0x4008587")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject TemplateUnit;
    [Token(Token = "0x4008588")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject GoParentReward;
    [Token(Token = "0x4008589")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private RewardIcon TemplateReward;
    [Token(Token = "0x400858A")]
    [FieldOffset(Offset = "0x30")]
    private int mIndex;
    [Token(Token = "0x400858B")]
    [FieldOffset(Offset = "0x34")]
    private AdventureHistory mHistoryData;

    [Token(Token = "0x170012A6")]
    public int Index
    {
      [Token(Token = "0x60081D4"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170012A7")]
    public AdventureHistory HistoryData
    {
      [Token(Token = "0x60081D5"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (AdventureHistory) null;
      }
    }

    [Token(Token = "0x60081D6")]
    [Address(RVA = "0x422350", Offset = "0x421150", VA = "0x10422350")]
    public void Setup(int index, AdventureHistory history_data)
    {
    }

    [Token(Token = "0x60081D7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureHistoryItem()
    {
    }
  }
}
