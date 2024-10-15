// Decompiled with JetBrains decompiler
// Type: SRPG.UsageRateRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D2E")]
  [AddComponentMenu("UI/UsageRateRanking")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  public class UsageRateRanking : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E134")]
    [FieldOffset(Offset = "0xC")]
    public GameObject ItemBase;
    [Token(Token = "0x400E135")]
    [FieldOffset(Offset = "0x10")]
    public GameObject Parent;
    [Token(Token = "0x400E136")]
    [FieldOffset(Offset = "0x14")]
    public GameObject Aggregating;
    [Token(Token = "0x400E137")]
    [FieldOffset(Offset = "0x18")]
    private List<UsageRateRankingItem> Items;
    [Token(Token = "0x400E138")]
    [FieldOffset(Offset = "0x1C")]
    public Scrollbar ItemScrollBar;
    [Token(Token = "0x400E139")]
    [FieldOffset(Offset = "0x20")]
    private UsageRateRanking.ViewInfoType mNowViewInfoType;
    [Token(Token = "0x400E13A")]
    [FieldOffset(Offset = "0x24")]
    public Toggle[] RankingToggle;
    [Token(Token = "0x400E13B")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string[] ViewInfo;

    [Token(Token = "0x17001B9A")]
    public byte NowViewInfoIndex
    {
      [Token(Token = "0x600D287"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new byte();
      }
    }

    [Token(Token = "0x17001B9B")]
    public string NowViewInfo
    {
      [Token(Token = "0x600D288"), Address(RVA = "0x9DAD20", Offset = "0x9D9B20", VA = "0x109DAD20")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x600D289")]
    [Address(RVA = "0x9DA9D0", Offset = "0x9D97D0", VA = "0x109DA9D0")]
    public void Start()
    {
    }

    [Token(Token = "0x600D28A")]
    [Address(RVA = "0x9DA5A0", Offset = "0x9D93A0", VA = "0x109DA5A0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D28B")]
    [Address(RVA = "0x9DA6A0", Offset = "0x9D94A0", VA = "0x109DA6A0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600D28C")]
    [Address(RVA = "0x9DA5C0", Offset = "0x9D93C0", VA = "0x109DA5C0")]
    private void OnChangedToggle(int index)
    {
    }

    [Token(Token = "0x600D28D")]
    [Address(RVA = "0x9DA5C0", Offset = "0x9D93C0", VA = "0x109DA5C0")]
    public void OnChangedToggle(UsageRateRanking.ViewInfoType index)
    {
    }

    [Token(Token = "0x600D28E")]
    [Address(RVA = "0x9DACB0", Offset = "0x9D9AB0", VA = "0x109DACB0")]
    public UsageRateRanking()
    {
    }

    [Token(Token = "0x600D28F")]
    [Address(RVA = "0x9DAB40", Offset = "0x9D9940", VA = "0x109DAB40")]
    static UsageRateRanking()
    {
    }

    [Token(Token = "0x2002D2F")]
    public enum ViewInfoType : byte
    {
      [Token(Token = "0x400E13D")] Quest,
      [Token(Token = "0x400E13E")] Arena,
      [Token(Token = "0x400E13F")] TowerMatch,
      [Token(Token = "0x400E140")] Num,
    }
  }
}
