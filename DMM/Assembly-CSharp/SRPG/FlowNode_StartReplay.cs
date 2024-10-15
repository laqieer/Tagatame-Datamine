// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_StartReplay
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200163A")]
  [FlowNode.NodeType("System/Replay/StartReplay", 32741)]
  [FlowNode.Pin(10, "Started", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  [FlowNode.Pin(0, "Load", FlowNode.PinTypes.Input, 0)]
  public class FlowNode_StartReplay : FlowNode
  {
    [Token(Token = "0x40050B4")]
    private const string ReplaySceneName = "Replay";
    [Token(Token = "0x40050B5")]
    private const int PIN_ID_LOAD = 0;
    [Token(Token = "0x40050B6")]
    private const int PIN_ID_STARTED = 10;
    [Token(Token = "0x40050B7")]
    private const int PIN_ID_FAILED = 11;
    [Token(Token = "0x40050B8")]
    [FieldOffset(Offset = "0x18")]
    [HideInInspector]
    public RestorePoints RestorePoint;
    [Token(Token = "0x40050B9")]
    [FieldOffset(Offset = "0x1C")]
    public bool SetRestorePoint;

    [Token(Token = "0x6005B5F")]
    [Address(RVA = "0x13015D0", Offset = "0x13003D0", VA = "0x113015D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005B60")]
    [Address(RVA = "0x1301720", Offset = "0x1300520", VA = "0x11301720")]
    private void OnSceneLoad(GameObject sceneRoot)
    {
    }

    [Token(Token = "0x6005B61")]
    [Address(RVA = "0x13017D0", Offset = "0x13005D0", VA = "0x113017D0")]
    private IEnumerator StartScene(QuestParam questParam) => (IEnumerator) null;

    [Token(Token = "0x6005B62")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_StartReplay()
    {
    }

    [Token(Token = "0x200163B")]
    private class QuestLauncher
    {
      [Token(Token = "0x40050BA")]
      [FieldOffset(Offset = "0x8")]
      private QuestParam mQuestParam;

      [Token(Token = "0x6005B63")]
      [Address(RVA = "0x3901F0", Offset = "0x38EFF0", VA = "0x103901F0")]
      public QuestLauncher(QuestParam questParam)
      {
      }

      [Token(Token = "0x6005B64")]
      [Address(RVA = "0x13020D0", Offset = "0x1300ED0", VA = "0x113020D0")]
      public void OnSceneAwake(GameObject scene)
      {
      }
    }
  }
}
