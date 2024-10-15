// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_Movie
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200121F")]
  [EventActionInfo("New/Movie", "指定のムービーをストリーミング再生します", 5592405, 4473992)]
  public class EventAction_Movie : EventAction
  {
    [Token(Token = "0x4004272")]
    [FieldOffset(Offset = "0x0")]
    private static readonly string PREFIX;
    [Token(Token = "0x4004273")]
    [FieldOffset(Offset = "0x18")]
    public string Filename;
    [Token(Token = "0x4004274")]
    [FieldOffset(Offset = "0x1C")]
    public float FadeTime;
    [Token(Token = "0x4004275")]
    [FieldOffset(Offset = "0x20")]
    public bool AutoFade;
    [Token(Token = "0x4004276")]
    [FieldOffset(Offset = "0x24")]
    public Color FadeColor;
    [Token(Token = "0x4004277")]
    [FieldOffset(Offset = "0x34")]
    private bool Played;
    [Token(Token = "0x4004278")]
    [FieldOffset(Offset = "0x38")]
    private string PlayFilename;
    [Token(Token = "0x4004279")]
    [FieldOffset(Offset = "0x3C")]
    private MySound.VolumeHandle hBGMVolume;
    [Token(Token = "0x400427A")]
    [FieldOffset(Offset = "0x40")]
    private MySound.VolumeHandle hVoiceVolume;
    [Token(Token = "0x400427B")]
    private const string PREFAB_PATH = "UI/FullScreenMovieDemo";

    [Token(Token = "0x6004CDC")]
    [Address(RVA = "0x121FDC0", Offset = "0x121EBC0", VA = "0x1121FDC0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004CDD")]
    [Address(RVA = "0x121FE40", Offset = "0x121EC40", VA = "0x1121FE40")]
    private void PlayMovie(string filename)
    {
    }

    [Token(Token = "0x6004CDE")]
    [Address(RVA = "0x1220060", Offset = "0x121EE60", VA = "0x11220060", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CDF")]
    [Address(RVA = "0x121FC90", Offset = "0x121EA90", VA = "0x1121FC90")]
    public void Finished(bool is_replay = false)
    {
    }

    [Token(Token = "0x6004CE0")]
    [Address(RVA = "0x280EB0", Offset = "0x27FCB0", VA = "0x10280EB0", Slot = "13")]
    public override bool ReplaySkipButtonEnable() => new bool();

    [Token(Token = "0x6004CE1")]
    [Address(RVA = "0x121FD80", Offset = "0x121EB80", VA = "0x1121FD80", Slot = "11")]
    public override void GoToEndState()
    {
    }

    [Token(Token = "0x6004CE2")]
    [Address(RVA = "0x1220020", Offset = "0x121EE20", VA = "0x11220020", Slot = "10")]
    public override void SkipImmediate()
    {
    }

    [Token(Token = "0x6004CE3")]
    [Address(RVA = "0x1220180", Offset = "0x121EF80", VA = "0x11220180")]
    public EventAction_Movie()
    {
    }

    [Token(Token = "0x6004CE4")]
    [Address(RVA = "0x1220130", Offset = "0x121EF30", VA = "0x11220130")]
    static EventAction_Movie()
    {
    }
  }
}
