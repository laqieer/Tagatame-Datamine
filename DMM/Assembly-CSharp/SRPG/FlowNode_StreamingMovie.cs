// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_StreamingMovie
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001641")]
  [FlowNode.Pin(3, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(4, "Failed", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(5, "Finished", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("UI/StreamingMovie", 32741)]
  [FlowNode.Pin(1000, "Play", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_StreamingMovie : FlowNode
  {
    [Token(Token = "0x40050CB")]
    private const int PIN_ID_OUT_SUCCESS = 3;
    [Token(Token = "0x40050CC")]
    private const int PIN_ID_OUT_FAILED = 4;
    [Token(Token = "0x40050CD")]
    private const int PIN_ID_OUT_FINISHED = 5;
    [Token(Token = "0x40050CE")]
    private const int PIN_ID_IN_PLAY = 1000;
    [Token(Token = "0x40050CF")]
    [FieldOffset(Offset = "0x18")]
    public string FileName;
    [Token(Token = "0x40050D0")]
    [FieldOffset(Offset = "0x1C")]
    private MySound.VolumeHandle hBGMVolume;
    [Token(Token = "0x40050D1")]
    [FieldOffset(Offset = "0x20")]
    private MySound.VolumeHandle hVoiceVolume;
    [Token(Token = "0x40050D2")]
    [FieldOffset(Offset = "0x24")]
    public string ReplayText;
    [Token(Token = "0x40050D3")]
    [FieldOffset(Offset = "0x28")]
    public string RetryText;
    [Token(Token = "0x40050D4")]
    [FieldOffset(Offset = "0x2C")]
    public bool AutoFade;
    [Token(Token = "0x40050D5")]
    [FieldOffset(Offset = "0x30")]
    public Color FadeColor;
    [Token(Token = "0x40050D6")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Space(5f)]
    private StreamingMovie.eSkipType SkipType;
    [Token(Token = "0x40050D7")]
    private const float FadeTime = 1f;

    [Token(Token = "0x6005B78")]
    [Address(RVA = "0x1301840", Offset = "0x1300640", VA = "0x11301840", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B79")]
    [Address(RVA = "0x1301C30", Offset = "0x1300A30", VA = "0x11301C30")]
    private void Play(string fileName)
    {
    }

    [Token(Token = "0x6005B7A")]
    [Address(RVA = "0x13019D0", Offset = "0x13007D0", VA = "0x113019D0")]
    public void OnFinished(bool is_replay = false)
    {
    }

    [Token(Token = "0x6005B7B")]
    [Address(RVA = "0x1301B80", Offset = "0x1300980", VA = "0x11301B80")]
    private void OnRetry(GameObject go)
    {
    }

    [Token(Token = "0x6005B7C")]
    [Address(RVA = "0x13019A0", Offset = "0x13007A0", VA = "0x113019A0")]
    private void OnCancelRetry(GameObject go)
    {
    }

    [Token(Token = "0x6005B7D")]
    [Address(RVA = "0x1301970", Offset = "0x1300770", VA = "0x11301970")]
    private void OnCancelReplay(GameObject go)
    {
    }

    [Token(Token = "0x6005B7E")]
    [Address(RVA = "0x1301BB0", Offset = "0x13009B0", VA = "0x11301BB0")]
    private IEnumerator PlayDelayed(string filename, StreamingMovie.OnFinished callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6005B7F")]
    [Address(RVA = "0x1301EA0", Offset = "0x1300CA0", VA = "0x11301EA0")]
    public FlowNode_StreamingMovie()
    {
    }
  }
}
