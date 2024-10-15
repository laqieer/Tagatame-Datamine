// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SetBackground
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012A3")]
  [EventActionInfo("背景/配置(2D)", "背景を配置します", 5592405, 4473992)]
  public class Event2dAction_SetBackground : EventAction
  {
    [Token(Token = "0x400454C")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public Texture2D Background;
    [Token(Token = "0x400454D")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public EventBackGround mBackGround;
    [Token(Token = "0x400454E")]
    [FieldOffset(Offset = "0x20")]
    private LoadRequest mBackGroundResource;
    [Token(Token = "0x400454F")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;

    [Token(Token = "0x170008D5")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004EF8"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004EF9")]
    [Address(RVA = "0x1243F60", Offset = "0x1242D60", VA = "0x11243F60", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004EFA")]
    [Address(RVA = "0x1243D80", Offset = "0x1242B80", VA = "0x11243D80", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004EFB")]
    [Address(RVA = "0x1243B60", Offset = "0x1242960", VA = "0x11243B60", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004EFC")]
    [Address(RVA = "0x1243CF0", Offset = "0x1242AF0", VA = "0x11243CF0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004EFD")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_SetBackground()
    {
    }

    [Token(Token = "0x6004EFE")]
    [Address(RVA = "0x1243FD0", Offset = "0x1242DD0", VA = "0x11243FD0")]
    static Event2dAction_SetBackground()
    {
    }
  }
}
