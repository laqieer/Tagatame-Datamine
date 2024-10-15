// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_QuitEnable
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200129C")]
  [EventActionInfo("強制終了/許可(2D)", "強制終了を許可します", 5592405, 4473992)]
  public class Event2dAction_QuitEnable : EventAction
  {
    [Token(Token = "0x4004527")]
    [FieldOffset(Offset = "0x0")]
    protected static EventQuit mQuit;
    [Token(Token = "0x4004528")]
    [FieldOffset(Offset = "0x18")]
    private LoadRequest mResource;
    [Token(Token = "0x4004529")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string AssetPath;

    [Token(Token = "0x170008D1")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004ED5"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004ED6")]
    [Address(RVA = "0x1242460", Offset = "0x1241260", VA = "0x11242460", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004ED7")]
    [Address(RVA = "0x1242200", Offset = "0x1241000", VA = "0x11242200", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004ED8")]
    [Address(RVA = "0x12420B0", Offset = "0x1240EB0", VA = "0x112420B0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004ED9")]
    [Address(RVA = "0x12421A0", Offset = "0x1240FA0", VA = "0x112421A0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004EDA")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_QuitEnable()
    {
    }

    [Token(Token = "0x6004EDB")]
    [Address(RVA = "0x1242500", Offset = "0x1241300", VA = "0x11242500")]
    static Event2dAction_QuitEnable()
    {
    }
  }
}
