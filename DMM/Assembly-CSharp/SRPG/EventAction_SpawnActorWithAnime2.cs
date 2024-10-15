// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SpawnActorWithAnime2
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001246")]
  [EventActionInfo("New/アクター/配置(アニメーション再生付）2", "キャラクターを配置します", 6702148, 11158596)]
  internal class EventAction_SpawnActorWithAnime2 : EventAction_SpawnActor2
  {
    [Token(Token = "0x4004345")]
    [FieldOffset(Offset = "0x54")]
    public EventAction_SpawnActorWithAnime2.PREFIX_PATH Path;
    [Token(Token = "0x4004346")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    public string m_AnimationName;
    [Token(Token = "0x4004347")]
    [FieldOffset(Offset = "0x5C")]
    [HideInInspector]
    public bool m_Loop;
    [Token(Token = "0x4004348")]
    [FieldOffset(Offset = "0x60")]
    public EventAction_SpawnActorWithAnime2.AnimeType m_AnimeType;
    [Token(Token = "0x4004349")]
    [FieldOffset(Offset = "0x64")]
    private string m_AnimationID;
    [Token(Token = "0x400434A")]
    [FieldOffset(Offset = "0x68")]
    [HideInInspector]
    [Tooltip("走りアニメーションを指定出来ます。")]
    public string m_RunAnimation;
    [Token(Token = "0x400434B")]
    private const string MOVIE_PATH = "Movies/";
    [Token(Token = "0x400434C")]
    private const string DEMO_PATH = "Demo/";

    [Token(Token = "0x170008A6")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D6C"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D6D")]
    [Address(RVA = "0x12303C0", Offset = "0x122F1C0", VA = "0x112303C0", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D6E")]
    [Address(RVA = "0x12300A0", Offset = "0x122EEA0", VA = "0x112300A0", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D6F")]
    [Address(RVA = "0x1230330", Offset = "0x122F130", VA = "0x11230330", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004D70")]
    [Address(RVA = "0x1230070", Offset = "0x122EE70", VA = "0x11230070")]
    public EventAction_SpawnActorWithAnime2()
    {
    }

    [Token(Token = "0x2001247")]
    public enum AnimeType
    {
      [Token(Token = "0x400434E")] Custom,
      [Token(Token = "0x400434F")] Idel,
    }

    [Token(Token = "0x2001248")]
    public enum PREFIX_PATH
    {
      [Token(Token = "0x4004351")] Demo,
      [Token(Token = "0x4004352")] Movie,
      [Token(Token = "0x4004353")] Default,
    }
  }
}
