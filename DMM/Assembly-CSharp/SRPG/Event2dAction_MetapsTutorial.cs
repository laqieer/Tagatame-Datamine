// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_MetapsTutorial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001293")]
  [EventActionInfo("MetapsTutorial用", "チュートリアルのトラッキング埋め込み用", 5592405, 4473992)]
  public class Event2dAction_MetapsTutorial : EventAction
  {
    [Token(Token = "0x40044C3")]
    [FieldOffset(Offset = "0x18")]
    public string Point;

    [Token(Token = "0x6004EB2")]
    [Address(RVA = "0x123F650", Offset = "0x123E450", VA = "0x1123F650", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EB3")]
    [Address(RVA = "0x123F670", Offset = "0x123E470", VA = "0x1123F670")]
    public Event2dAction_MetapsTutorial()
    {
    }
  }
}
