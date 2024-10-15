// Decompiled with JetBrains decompiler
// Type: SRPG.Event2dAction_SpawnStandchara
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012B1")]
  [EventActionInfo("立ち絵/配置(2D)", "立ち絵を配置します", 5592405, 4473992)]
  public class Event2dAction_SpawnStandchara : EventAction
  {
    [Token(Token = "0x4004589")]
    [FieldOffset(Offset = "0x18")]
    public string CharaID;
    [Token(Token = "0x400458A")]
    [FieldOffset(Offset = "0x1C")]
    public bool Flip;
    [Token(Token = "0x400458B")]
    [FieldOffset(Offset = "0x20")]
    public EventStandChara.PositionTypes Position;
    [Token(Token = "0x400458C")]
    [FieldOffset(Offset = "0x24")]
    [HideInInspector]
    public Texture2D StandcharaImage;
    [Token(Token = "0x400458D")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public EventStandChara mStandChara;
    [Token(Token = "0x400458E")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public IEnumerator mEnumerator;
    [Token(Token = "0x400458F")]
    [FieldOffset(Offset = "0x30")]
    private LoadRequest mStandCharaResource;
    [Token(Token = "0x4004590")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string AssetPath;

    [Token(Token = "0x170008E4")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004F39"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004F3A")]
    [Address(RVA = "0x1245C70", Offset = "0x1244A70", VA = "0x11245C70", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004F3B")]
    [Address(RVA = "0x12459D0", Offset = "0x12447D0", VA = "0x112459D0", Slot = "15")]
    public override void PreStart()
    {
    }

    [Token(Token = "0x6004F3C")]
    [Address(RVA = "0x1245590", Offset = "0x1244390", VA = "0x11245590", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004F3D")]
    [Address(RVA = "0x1245940", Offset = "0x1244740", VA = "0x11245940", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004F3E")]
    [Address(RVA = "0x1245CE0", Offset = "0x1244AE0", VA = "0x11245CE0", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004F3F")]
    [Address(RVA = "0x9E0D30", Offset = "0x9DFB30", VA = "0x109E0D30")]
    public Event2dAction_SpawnStandchara()
    {
    }

    [Token(Token = "0x6004F40")]
    [Address(RVA = "0x1245D70", Offset = "0x1244B70", VA = "0x11245D70")]
    static Event2dAction_SpawnStandchara()
    {
    }

    [Token(Token = "0x20012B2")]
    public enum StateTypes
    {
      [Token(Token = "0x4004592")] Initialized,
      [Token(Token = "0x4004593")] StartFadeIn,
      [Token(Token = "0x4004594")] FadeIn,
      [Token(Token = "0x4004595")] EndFadeIn,
      [Token(Token = "0x4004596")] StartFadeOut,
      [Token(Token = "0x4004597")] FadeOut,
      [Token(Token = "0x4004598")] EndFadeOut,
      [Token(Token = "0x4004599")] Active,
      [Token(Token = "0x400459A")] Inactive,
    }
  }
}
