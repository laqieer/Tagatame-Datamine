// Decompiled with JetBrains decompiler
// Type: SRPG.SceneReplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010FB")]
  [AddComponentMenu("Common/SceneReplay")]
  [FlowNode.Pin(0, "Skip", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Skip生成完了", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "次のシナリオ再生", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(101, "次のシナリオ再生する？", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(111, "シナリオ終了", FlowNode.PinTypes.Output, 111)]
  public class SceneReplay : Scene, IFlowInterface
  {
    [Token(Token = "0x4003D53")]
    [FieldOffset(Offset = "0x0")]
    public static readonly string QUEST_TEXTTABLE;
    [Token(Token = "0x4003D54")]
    private const string CREATE_SKIP_CANVAS = "CREATE_SKIP_CANVAS";
    [Token(Token = "0x4003D55")]
    private const string DESTROY_SKIP_CANVAS = "DESTROY_SKIP_CANVAS";
    [Token(Token = "0x4003D56")]
    private const string ENABLE_SKIP_BUTTON = "ENABLE_SKIP";
    [Token(Token = "0x4003D57")]
    private const string DISABLE_SKIP_BUTTON = "DISABLE_SKIP";
    [Token(Token = "0x4003D58")]
    private const string SCENE_EXIT = "EXIT";
    [Token(Token = "0x4003D59")]
    private const string SCENE_NEXT = "NEXT";
    [Token(Token = "0x4003D5A")]
    private const int PIN_ID_SKIP = 0;
    [Token(Token = "0x4003D5B")]
    private const int PIN_ID_SKIP_CANVAS_CREATED = 1;
    [Token(Token = "0x4003D5C")]
    private const int PIN_ID_CONTINUE = 11;
    [Token(Token = "0x4003D5D")]
    private const int PIN_ID_OUT_DIALOG_CONTINUE = 101;
    [Token(Token = "0x4003D5E")]
    private const int PIN_ID_OUT_END = 111;
    [Token(Token = "0x4003D5F")]
    [FieldOffset(Offset = "0x10")]
    private StateMachine<SceneReplay> mState;
    [Token(Token = "0x4003D60")]
    [FieldOffset(Offset = "0x14")]
    private bool mStartCalled;
    [Token(Token = "0x4003D61")]
    [FieldOffset(Offset = "0x18")]
    private QuestParam mCurrentQuest;
    [Token(Token = "0x4003D62")]
    [FieldOffset(Offset = "0x1C")]
    private QuestParam mNextQuest;
    [Token(Token = "0x4003D63")]
    [FieldOffset(Offset = "0x20")]
    private BattleCore mBattle;
    [Token(Token = "0x4003D64")]
    [FieldOffset(Offset = "0x24")]
    private IEnumerator<string> mEventNames;
    [Token(Token = "0x4003D65")]
    [FieldOffset(Offset = "0x28")]
    public bool mAutoReplay;
    [Token(Token = "0x4003D66")]
    [FieldOffset(Offset = "0x29")]
    private bool skip;
    [Token(Token = "0x4003D67")]
    [FieldOffset(Offset = "0x2A")]
    private bool canvasCreating;
    [Token(Token = "0x4003D68")]
    [FieldOffset(Offset = "0x2B")]
    private bool mSceneExiting;
    [Token(Token = "0x4003D69")]
    [FieldOffset(Offset = "0x2C")]
    private List<string> mPlayableScenario;
    [Token(Token = "0x4003D6A")]
    [FieldOffset(Offset = "0x30")]
    private QuestParam[] mChapterQuests;

    [Token(Token = "0x60047FD")]
    [Address(RVA = "0x11F2800", Offset = "0x11F1600", VA = "0x111F2800", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60047FE")]
    [Address(RVA = "0x11F3150", Offset = "0x11F1F50", VA = "0x111F3150")]
    private void Start()
    {
    }

    [Token(Token = "0x60047FF")]
    [Address(RVA = "0x11F2EF0", Offset = "0x11F1CF0", VA = "0x111F2EF0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6004800")]
    [Address(RVA = "0x11F2F80", Offset = "0x11F1D80", VA = "0x111F2F80")]
    public void RemoveLog()
    {
    }

    [Token(Token = "0x6004801")]
    [Address(RVA = "0x11F3270", Offset = "0x11F2070", VA = "0x111F3270")]
    private void Update()
    {
    }

    [Token(Token = "0x6004802")]
    public void GotoState<StateType>() where StateType : State<SceneReplay>, new()
    {
    }

    [Token(Token = "0x6004803")]
    public bool IsInState<StateType>() where StateType : State<SceneReplay> => new bool();

    [Token(Token = "0x6004804")]
    [Address(RVA = "0x11F30B0", Offset = "0x11F1EB0", VA = "0x111F30B0")]
    public void StartQuest(string questID)
    {
    }

    [Token(Token = "0x6004805")]
    [Address(RVA = "0x11F3040", Offset = "0x11F1E40", VA = "0x111F3040")]
    private IEnumerator StartQuestAsync(string questID) => (IEnumerator) null;

    [Token(Token = "0x6004806")]
    [Address(RVA = "0x11F2AE0", Offset = "0x11F18E0", VA = "0x111F2AE0")]
    private IEnumerator DownloadQuestAsync(QuestParam quest) => (IEnumerator) null;

    [Token(Token = "0x6004807")]
    [Address(RVA = "0x11F29F0", Offset = "0x11F17F0", VA = "0x111F29F0")]
    private void CreateSkipCanvas()
    {
    }

    [Token(Token = "0x6004808")]
    [Address(RVA = "0x11F2A30", Offset = "0x11F1830", VA = "0x111F2A30")]
    private void DestroySkipCanvas()
    {
    }

    [Token(Token = "0x6004809")]
    [Address(RVA = "0x11F2B50", Offset = "0x11F1950", VA = "0x111F2B50")]
    private void EnableSkipButton()
    {
    }

    [Token(Token = "0x600480A")]
    [Address(RVA = "0x11F2A70", Offset = "0x11F1870", VA = "0x111F2A70")]
    private void DisableSkipButton()
    {
    }

    [Token(Token = "0x600480B")]
    [Address(RVA = "0x11F2BC0", Offset = "0x11F19C0", VA = "0x111F2BC0")]
    private void ExitScene()
    {
    }

    [Token(Token = "0x600480C")]
    [Address(RVA = "0x11F2C80", Offset = "0x11F1A80", VA = "0x111F2C80")]
    private QuestParam GetNextSceneQuest(QuestParam current) => (QuestParam) null;

    [Token(Token = "0x600480D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SceneReplay()
    {
    }

    [Token(Token = "0x600480E")]
    [Address(RVA = "0x11F32B0", Offset = "0x11F20B0", VA = "0x111F32B0")]
    static SceneReplay()
    {
    }

    [Token(Token = "0x20010FC")]
    private class State_PreReplay : State<SceneReplay>
    {
      [Token(Token = "0x600480F")]
      [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
      public override void Begin(SceneReplay self)
      {
      }

      [Token(Token = "0x6004810")]
      [Address(RVA = "0x11FC500", Offset = "0x11FB300", VA = "0x111FC500", Slot = "5")]
      public override void Update(SceneReplay self)
      {
      }

      [Token(Token = "0x6004811")]
      [Address(RVA = "0x11FC590", Offset = "0x11FB390", VA = "0x111FC590")]
      public State_PreReplay()
      {
      }
    }

    [Token(Token = "0x20010FD")]
    private class State_Replay : State<SceneReplay>
    {
      [Token(Token = "0x4003D6B")]
      [FieldOffset(Offset = "0xC")]
      private string eventName;
      [Token(Token = "0x4003D6C")]
      [FieldOffset(Offset = "0x10")]
      private string path;
      [Token(Token = "0x4003D6D")]
      [FieldOffset(Offset = "0x14")]
      private bool is3DEvent;

      [Token(Token = "0x6004812")]
      [Address(RVA = "0x11FC5D0", Offset = "0x11FB3D0", VA = "0x111FC5D0", Slot = "4")]
      public override void Begin(SceneReplay self)
      {
      }

      [Token(Token = "0x6004813")]
      [Address(RVA = "0x11FC740", Offset = "0x11FB540", VA = "0x111FC740")]
      private IEnumerator Exec() => (IEnumerator) null;

      [Token(Token = "0x6004814")]
      [Address(RVA = "0x11FC7B0", Offset = "0x11FB5B0", VA = "0x111FC7B0")]
      public State_Replay()
      {
      }
    }

    [Token(Token = "0x20010FF")]
    private class State_PostReplay : State<SceneReplay>
    {
      [Token(Token = "0x4003D77")]
      [FieldOffset(Offset = "0xC")]
      private AsyncOperation mAsyncOp;

      [Token(Token = "0x600481B")]
      [Address(RVA = "0x11FC3D0", Offset = "0x11FB1D0", VA = "0x111FC3D0", Slot = "4")]
      public override void Begin(SceneReplay self)
      {
      }

      [Token(Token = "0x600481C")]
      [Address(RVA = "0x11FC420", Offset = "0x11FB220", VA = "0x111FC420", Slot = "5")]
      public override void Update(SceneReplay self)
      {
      }

      [Token(Token = "0x600481D")]
      [Address(RVA = "0x11FC4C0", Offset = "0x11FB2C0", VA = "0x111FC4C0")]
      public State_PostReplay()
      {
      }
    }

    [Token(Token = "0x2001100")]
    private class State_Exit : State<SceneReplay>
    {
      [Token(Token = "0x600481E")]
      [Address(RVA = "0x11FC2C0", Offset = "0x11FB0C0", VA = "0x111FC2C0", Slot = "4")]
      public override void Begin(SceneReplay self)
      {
      }

      [Token(Token = "0x600481F")]
      [Address(RVA = "0x11FC390", Offset = "0x11FB190", VA = "0x111FC390")]
      public State_Exit()
      {
      }
    }
  }
}
