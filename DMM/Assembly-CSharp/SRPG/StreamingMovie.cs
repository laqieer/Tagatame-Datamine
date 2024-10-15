// Decompiled with JetBrains decompiler
// Type: SRPG.StreamingMovie
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using GR;
using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001163")]
  [AddComponentMenu("Common/StreamingMovie")]
  public class StreamingMovie : MonoSingleton<StreamingMovie>
  {
    [Token(Token = "0x4003EEA")]
    private const string PREFAB_PATH = "UI/FullScreenMovie";
    [Token(Token = "0x4003EEB")]
    [FieldOffset(Offset = "0xC")]
    private StreamingMovie.OnFinished onFinished;
    [Token(Token = "0x4003EEC")]
    [FieldOffset(Offset = "0x10")]
    private bool skip;
    [Token(Token = "0x4003EED")]
    [FieldOffset(Offset = "0x14")]
    private StreamingMovie.Result playing_movie_info;
    [Token(Token = "0x4003EEE")]
    [FieldOffset(Offset = "0x18")]
    private bool m_NotReplay;
    [Token(Token = "0x4003EEF")]
    [FieldOffset(Offset = "0x1C")]
    private MySound.VolumeHandle hBGMVolume;
    [Token(Token = "0x4003EF0")]
    [FieldOffset(Offset = "0x20")]
    private MySound.VolumeHandle hVoiceVolume;
    [Token(Token = "0x4003EF1")]
    [FieldOffset(Offset = "0x24")]
    private bool isSoundStop;

    [Token(Token = "0x17000812")]
    private string URL
    {
      [Token(Token = "0x6004A12"), Address(RVA = "0x1207EF0", Offset = "0x1206CF0", VA = "0x11207EF0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000813")]
    private string PlatformMovieSuffix
    {
      [Token(Token = "0x6004A13"), Address(RVA = "0x1207EC0", Offset = "0x1206CC0", VA = "0x11207EC0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000814")]
    private string Extention
    {
      [Token(Token = "0x6004A14"), Address(RVA = "0x1207DE0", Offset = "0x1206BE0", VA = "0x11207DE0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000815")]
    public bool IsNotReplay
    {
      [Token(Token = "0x6004A15"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
      [Token(Token = "0x6004A16"), Address(RVA = "0x305870", Offset = "0x304670", VA = "0x10305870")] set
      {
      }
    }

    [Token(Token = "0x17000816")]
    public static bool IsPlaying
    {
      [Token(Token = "0x6004A17"), Address(RVA = "0x1207E10", Offset = "0x1206C10", VA = "0x11207E10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6004A18")]
    [Address(RVA = "0x1207540", Offset = "0x1206340", VA = "0x11207540", Slot = "4")]
    protected override void Initialize()
    {
    }

    [Token(Token = "0x6004A19")]
    [Address(RVA = "0x1207C80", Offset = "0x1206A80", VA = "0x11207C80", Slot = "5")]
    protected override void Release()
    {
    }

    [Token(Token = "0x6004A1A")]
    [Address(RVA = "0x9E1670", Offset = "0x9E0470", VA = "0x109E1670")]
    public void Skip()
    {
    }

    [Token(Token = "0x6004A1B")]
    [Address(RVA = "0x1207CC0", Offset = "0x1206AC0", VA = "0x11207CC0")]
    public void StopSound()
    {
    }

    [Token(Token = "0x6004A1C")]
    [Address(RVA = "0x1207AF0", Offset = "0x12068F0", VA = "0x11207AF0")]
    public bool Play(
      string fileName,
      StreamingMovie.OnFinished callback = null,
      string prefabPath = null,
      StreamingMovie.eSkipType skip_type = StreamingMovie.eSkipType.Normal)
    {
      return new bool();
    }

    [Token(Token = "0x6004A1D")]
    [Address(RVA = "0x1207580", Offset = "0x1206380", VA = "0x11207580")]
    private string MakePlatformMoviePath(string fileName) => (string) null;

    [Token(Token = "0x6004A1E")]
    [Address(RVA = "0x1207A60", Offset = "0x1206860", VA = "0x11207A60")]
    private IEnumerator PlayInternal(
      string url,
      string prefabPath,
      StreamingMovie.eSkipType skip_type)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6004A1F")]
    [Address(RVA = "0x12073C0", Offset = "0x12061C0", VA = "0x112073C0")]
    private void Finish()
    {
    }

    [Token(Token = "0x6004A20")]
    [Address(RVA = "0x1207760", Offset = "0x1206560", VA = "0x11207760")]
    private static StreamingMovie.Result PlayFullScreenMovie(
      string url,
      string prefabPath,
      StreamingMovie.eSkipType skip_type)
    {
      return (StreamingMovie.Result) null;
    }

    [Token(Token = "0x6004A21")]
    [Address(RVA = "0x1207DA0", Offset = "0x1206BA0", VA = "0x11207DA0")]
    public StreamingMovie()
    {
    }

    [Token(Token = "0x2001164")]
    public enum eSkipType
    {
      [Token(Token = "0x4003EF3")] Normal,
      [Token(Token = "0x4003EF4")] ForceSkip,
      [Token(Token = "0x4003EF5")] NoSkip,
    }

    [Token(Token = "0x2001165")]
    public delegate void OnFinished(bool is_replay);

    [Token(Token = "0x2001166")]
    private class Result
    {
      [Token(Token = "0x4003EF6")]
      [FieldOffset(Offset = "0x8")]
      public bool isEnd;

      [Token(Token = "0x6004A26")]
      [Address(RVA = "0x12006A0", Offset = "0x11FF4A0", VA = "0x112006A0")]
      public Result(
        FlowNode_MediaPlayerDispatchFinishEvent finishEventDispatcher)
      {
      }

      [Token(Token = "0x6004A27")]
      [Address(RVA = "0x5A7790", Offset = "0x5A6590", VA = "0x105A7790")]
      private void OnEnd()
      {
      }
    }
  }
}
