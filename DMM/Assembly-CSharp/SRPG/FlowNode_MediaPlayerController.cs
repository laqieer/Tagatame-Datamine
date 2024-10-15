// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MediaPlayerController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200142C")]
  [FlowNode.Pin(1010, "OnFirstFrameReady", FlowNode.PinTypes.Output, 1010)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1040, "OnError", FlowNode.PinTypes.Output, 1040)]
  [FlowNode.Pin(1030, "OnEnd", FlowNode.PinTypes.Output, 1030)]
  [FlowNode.Pin(1022, "OnBufferingTimeout", FlowNode.PinTypes.Output, 1022)]
  [FlowNode.Pin(1021, "OnBufferingEnd", FlowNode.PinTypes.Output, 1021)]
  [FlowNode.Pin(1020, "OnBufferingStart", FlowNode.PinTypes.Output, 1020)]
  [FlowNode.Pin(1000, "OnReady", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1050, "OnLoadFailed", FlowNode.PinTypes.Output, 1050)]
  [FlowNode.Pin(50, "Unload", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(40, "Skip", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(30, "Stop", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(20, "Pause", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(10, "Play", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("AVProVideo/MediaPlayerController")]
  [FlowNode.Pin(60, "Reload", FlowNode.PinTypes.Input, 60)]
  public class FlowNode_MediaPlayerController : FlowNodePersistent
  {
    [Token(Token = "0x4004A9F")]
    public const int PIN_ID_PLAY = 10;
    [Token(Token = "0x4004AA0")]
    public const int PIN_ID_PAUSE = 20;
    [Token(Token = "0x4004AA1")]
    public const int PIN_ID_STOP = 30;
    [Token(Token = "0x4004AA2")]
    public const int PIN_ID_SKIP = 40;
    [Token(Token = "0x4004AA3")]
    public const int PIN_ID_UNLOAD = 50;
    [Token(Token = "0x4004AA4")]
    public const int PIN_ID_RELOAD = 60;
    [Token(Token = "0x4004AA5")]
    public const int PIN_ID_ON_READY = 1000;
    [Token(Token = "0x4004AA6")]
    public const int PIN_ID_ON_FIRST_FRAME_READY = 1010;
    [Token(Token = "0x4004AA7")]
    public const int PIN_ID_ON_BUFFERING_START = 1020;
    [Token(Token = "0x4004AA8")]
    public const int PIN_ID_ON_BUFFERING_END = 1021;
    [Token(Token = "0x4004AA9")]
    public const int PIN_ID_ON_BUFFERING_TIMEOUT = 1022;
    [Token(Token = "0x4004AAA")]
    public const int PIN_ID_ON_END = 1030;
    [Token(Token = "0x4004AAB")]
    public const int PIN_ID_ON_ERROR = 1040;
    [Token(Token = "0x4004AAC")]
    public const int PIN_ID_ON_LOAD_FAILED = 1050;
    [Token(Token = "0x4004AAD")]
    [FieldOffset(Offset = "0x18")]
    public MediaPlayerWrapper m_MediaPlayerWrapper;
    [Token(Token = "0x4004AAE")]
    [FieldOffset(Offset = "0x1C")]
    public bool m_EnableBufferingTimeout;
    [Token(Token = "0x4004AAF")]
    [FieldOffset(Offset = "0x20")]
    public float m_BufferingGraceTime;
    [Token(Token = "0x4004AB0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Selectable SelDisplay;
    [Token(Token = "0x4004AB1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject GoForceSkip;
    [Token(Token = "0x4004AB2")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public StreamingMovie.eSkipType SkipType;

    [Token(Token = "0x6005435")]
    [Address(RVA = "0x128E870", Offset = "0x128D670", VA = "0x1128E870")]
    private void Start()
    {
    }

    [Token(Token = "0x6005436")]
    [Address(RVA = "0x128E740", Offset = "0x128D540", VA = "0x1128E740")]
    private void SetupSkip(bool is_normal_skip, bool is_force_skip)
    {
    }

    [Token(Token = "0x6005437")]
    [Address(RVA = "0x128E500", Offset = "0x128D300", VA = "0x1128E500", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005438")]
    [Address(RVA = "0x128E4D0", Offset = "0x128D2D0", VA = "0x1128E4D0")]
    public void Load(string url)
    {
    }

    [Token(Token = "0x6005439")]
    [Address(RVA = "0x128E710", Offset = "0x128D510", VA = "0x1128E710")]
    public void SetVolume(float value)
    {
    }

    [Token(Token = "0x600543A")]
    [Address(RVA = "0x128E610", Offset = "0x128D410", VA = "0x1128E610")]
    private void OnMediaPlayerEvent(MediaPlayerWrapper.Event.Type eventType)
    {
    }

    [Token(Token = "0x600543B")]
    [Address(RVA = "0x128E6F0", Offset = "0x128D4F0", VA = "0x1128E6F0")]
    private void OnReady()
    {
    }

    [Token(Token = "0x600543C")]
    [Address(RVA = "0x5EE2A0", Offset = "0x5ED0A0", VA = "0x105EE2A0")]
    private void OnFirstFrameReady()
    {
    }

    [Token(Token = "0x600543D")]
    [Address(RVA = "0x5EEB80", Offset = "0x5ED980", VA = "0x105EEB80")]
    private void OnFinished()
    {
    }

    [Token(Token = "0x600543E")]
    [Address(RVA = "0x5EE2C0", Offset = "0x5ED0C0", VA = "0x105EE2C0")]
    private void OnBufferingStart()
    {
    }

    [Token(Token = "0x600543F")]
    [Address(RVA = "0x128E5D0", Offset = "0x128D3D0", VA = "0x1128E5D0")]
    private void OnBufferingEnd()
    {
    }

    [Token(Token = "0x6005440")]
    [Address(RVA = "0x128E5F0", Offset = "0x128D3F0", VA = "0x1128E5F0")]
    private void OnBufferingTimeout()
    {
    }

    [Token(Token = "0x6005441")]
    [Address(RVA = "0x5EE460", Offset = "0x5ED260", VA = "0x105EE460")]
    private void OnError()
    {
    }

    [Token(Token = "0x6005442")]
    [Address(RVA = "0x5EE5E0", Offset = "0x5ED3E0", VA = "0x105EE5E0")]
    private void OnLoadFailed()
    {
    }

    [Token(Token = "0x6005443")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MediaPlayerController()
    {
    }
  }
}
