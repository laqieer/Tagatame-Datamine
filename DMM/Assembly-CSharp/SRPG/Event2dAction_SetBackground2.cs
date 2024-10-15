// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SetBackground2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012A5")]
  [EventActionInfo("New/背景/配置(2D)", "背景を配置します", 5592405, 4473992)]
  public class Event2dAction_SetBackground2 : EventAction
  {
    [Token(Token = "0x4004553")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public Texture2D Background;
    [Token(Token = "0x4004554")]
    [FieldOffset(Offset = "0x1C")]
    [HideInInspector]
    public EventBackGround mBackGround;
    [Token(Token = "0x4004555")]
    [FieldOffset(Offset = "0x20")]
    [HideInInspector]
    public bool NewMaterial;
    [Token(Token = "0x4004556")]
    [FieldOffset(Offset = "0x24")]
    private LoadRequest mBackGroundResource;
    [Token(Token = "0x4004557")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;
    [Token(Token = "0x4004558")]
    private const string SHADER_NAME = "UI/Custom/EventDefault";

    [Token(Token = "0x170008D8")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004F05"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004F06")]
    [Address(RVA = "0x1243A80", Offset = "0x1242880", VA = "0x11243A80", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F07")]
    [Address(RVA = "0x1243860", Offset = "0x1242660", VA = "0x11243860", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F08")]
    [Address(RVA = "0x1243570", Offset = "0x1242370", VA = "0x11243570", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F09")]
    [Address(RVA = "0x12437D0", Offset = "0x12425D0", VA = "0x112437D0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004F0A")]
    [Address(RVA = "0x1243B40", Offset = "0x1242940", VA = "0x11243B40")]
    public Event2dAction_SetBackground2()
    {
    }

    [Token(Token = "0x6004F0B")]
    [Address(RVA = "0x1243AF0", Offset = "0x12428F0", VA = "0x11243AF0")]
    static Event2dAction_SetBackground2()
    {
    }
  }
}
