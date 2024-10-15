// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_Filter
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001290")]
  [EventActionInfo("New/フィルタ(2D)", "画面に効果を適応します", 5592405, 4473992)]
  public class Event2dAction_Filter : EventAction
  {
    [Token(Token = "0x40044B2")]
    [FieldOffset(Offset = "0x18")]
    public Event2dAction_Filter.FilterType filter;

    [Token(Token = "0x6004EA9")]
    [Address(RVA = "0x123E480", Offset = "0x123D280", VA = "0x1123E480", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EAA")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_Filter()
    {
    }

    [Token(Token = "0x2001291")]
    public enum FilterType
    {
      [Token(Token = "0x40044B4")] None,
      [Token(Token = "0x40044B5")] Monochrome,
      [Token(Token = "0x40044B6")] Sepia,
    }
  }
}
