// Decompiled with JetBrains decompiler
// Type: SRPG.EventAction_MoveActorWithAnime
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200120D")]
  [EventActionInfo("New/アクター/移動(アニメーション再生付)", "アクターを指定パスに沿って移動させます。", 6702148, 11158596)]
  public class EventAction_MoveActorWithAnime : EventAction_MoveActor2
  {
    [Token(Token = "0x40041E7")]
    [FieldOffset(Offset = "0x4C")]
    [HideInInspector]
    public string m_AnimationName;
    [Token(Token = "0x40041E8")]
    [FieldOffset(Offset = "0x50")]
    [HideInInspector]
    public bool m_Loop;
    [Token(Token = "0x40041E9")]
    [FieldOffset(Offset = "0x54")]
    public EventAction_MoveActorWithAnime.AnimeType m_AnimeType;
    [Token(Token = "0x40041EA")]
    [FieldOffset(Offset = "0x58")]
    private string m_AnimationID;

    [Token(Token = "0x17000882")]
    public override bool IsPreloadAssets
    {
      [Token(Token = "0x6004CB3"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "12")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004CB4")]
    [Address(RVA = "0x121D910", Offset = "0x121C710", VA = "0x1121D910", Slot = "14")]
    public override IEnumerator PreloadAssets() => (IEnumerator) null;

    [Token(Token = "0x6004CB5")]
    [Address(RVA = "0x121D980", Offset = "0x121C780", VA = "0x1121D980", Slot = "6")]
    public override void Update()
    {
    }

    [Token(Token = "0x6004CB6")]
    [Address(RVA = "0x121D890", Offset = "0x121C690", VA = "0x1121D890", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6004CB7")]
    [Address(RVA = "0x121C440", Offset = "0x121B240", VA = "0x1121C440")]
    public EventAction_MoveActorWithAnime()
    {
    }

    [Token(Token = "0x200120E")]
    public enum AnimeType
    {
      [Token(Token = "0x40041EC")] Custom,
      [Token(Token = "0x40041ED")] Idel,
    }
  }
}
