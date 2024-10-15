// Decompiled with JetBrains decompiler
// Type: SRPG.SoundTrigger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001135")]
  [AddComponentMenu("Common/SoundTrigger")]
  [DisallowMultipleComponent]
  public class SoundTrigger : MonoBehaviour
  {
    [Token(Token = "0x4003EAB")]
    [FieldOffset(Offset = "0xC")]
    [FlexibleArray]
    public string[] VoiceNames;
    [Token(Token = "0x4003EAC")]
    [FieldOffset(Offset = "0x10")]
    private MySound.Voice[] mVoices;

    [Token(Token = "0x6004994")]
    [Address(RVA = "0x12064A0", Offset = "0x12052A0", VA = "0x112064A0")]
    private void Start()
    {
    }

    [Token(Token = "0x6004995")]
    [Address(RVA = "0x1206260", Offset = "0x1205060", VA = "0x11206260")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6004996")]
    [Address(RVA = "0x12063B0", Offset = "0x12051B0", VA = "0x112063B0")]
    public void PlayVoice(string cueID)
    {
    }

    [Token(Token = "0x6004997")]
    [Address(RVA = "0x1206360", Offset = "0x1205160", VA = "0x11206360")]
    public void PlaySE(string cueID)
    {
    }

    [Token(Token = "0x6004998")]
    [Address(RVA = "0x1206300", Offset = "0x1205100", VA = "0x11206300")]
    public void PlayJingle(string cueID)
    {
    }

    [Token(Token = "0x6004999")]
    [Address(RVA = "0x12065F0", Offset = "0x12053F0", VA = "0x112065F0")]
    public SoundTrigger()
    {
    }
  }
}
