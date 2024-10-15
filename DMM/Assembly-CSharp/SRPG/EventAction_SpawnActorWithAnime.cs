// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_SpawnActorWithAnime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001243")]
  [EventActionInfo("New/アクター/配置(アニメーション再生付）", "キャラクターを配置します", 6702148, 11158596)]
  internal class EventAction_SpawnActorWithAnime : EventAction_SpawnActor2
  {
    [Token(Token = "0x400433A")]
    [FieldOffset(Offset = "0x54")]
    [HideInInspector]
    public string m_AnimationName;
    [Token(Token = "0x400433B")]
    [FieldOffset(Offset = "0x58")]
    [HideInInspector]
    public bool m_Loop;
    [Token(Token = "0x400433C")]
    [FieldOffset(Offset = "0x5C")]
    public EventAction_SpawnActorWithAnime.AnimeType m_AnimeType;
    [Token(Token = "0x400433D")]
    [FieldOffset(Offset = "0x60")]
    private string m_AnimationID;
    [Token(Token = "0x400433E")]
    [FieldOffset(Offset = "0x64")]
    [Tooltip("走りアニメーションを指定出来ます。")]
    public string m_RunAnimation;

    [Token(Token = "0x170008A3")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004D61"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004D62")]
    [Address(RVA = "0x1230750", Offset = "0x122F550", VA = "0x11230750", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004D63")]
    [Address(RVA = "0x1230430", Offset = "0x122F230", VA = "0x11230430", Slot = "4")]
    public override void OnActivate()
    {
    }

    [Token(Token = "0x6004D64")]
    [Address(RVA = "0x12306C0", Offset = "0x122F4C0", VA = "0x112306C0", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004D65")]
    [Address(RVA = "0x1230070", Offset = "0x122EE70", VA = "0x11230070")]
    public EventAction_SpawnActorWithAnime()
    {
    }

    [Token(Token = "0x2001244")]
    public enum AnimeType
    {
      [Token(Token = "0x4004340")] Custom,
      [Token(Token = "0x4004341")] Idel,
    }
  }
}
