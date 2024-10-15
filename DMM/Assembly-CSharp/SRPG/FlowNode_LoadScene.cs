// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_LoadScene
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200141F")]
  [FlowNode.Pin(20, "Started", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Scene/LoadScene", 32741)]
  [FlowNode.Pin(100, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Finished", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(21, "Booted", FlowNode.PinTypes.Output, 21)]
  public class FlowNode_LoadScene : FlowNode
  {
    [Token(Token = "0x4004A73")]
    private const string StartSceneName = "1_CheckVersion";
    [Token(Token = "0x4004A74")]
    [FieldOffset(Offset = "0x18")]
    public FlowNode_LoadScene.SceneTypes SceneType;
    [Token(Token = "0x4004A75")]
    [FieldOffset(Offset = "0x1C")]
    public string SceneName;
    [Token(Token = "0x4004A76")]
    [FieldOffset(Offset = "0x20")]
    public float WaitTime;
    [Token(Token = "0x4004A77")]
    [FieldOffset(Offset = "0x24")]
    private float mLoadStartTime;
    [Token(Token = "0x4004A78")]
    [FieldOffset(Offset = "0x28")]
    private SceneRequest mOp;

    [Token(Token = "0x6005409")]
    [Address(RVA = "0x12884B0", Offset = "0x12872B0", VA = "0x112884B0")]
    public static void LoadBootScene()
    {
    }

    [Token(Token = "0x600540A")]
    [Address(RVA = "0x1288590", Offset = "0x1287390", VA = "0x11288590", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600540B")]
    [Address(RVA = "0x1288830", Offset = "0x1287630", VA = "0x11288830")]
    private IEnumerator PreLoadSceneAsync(string sceneName) => (IEnumerator) null;

    [Token(Token = "0x600540C")]
    [Address(RVA = "0x12888A0", Offset = "0x12876A0", VA = "0x112888A0")]
    private void PreLoadScene(string sceneName)
    {
    }

    [Token(Token = "0x600540D")]
    [Address(RVA = "0x12888B0", Offset = "0x12876B0", VA = "0x112888B0")]
    private void StartSceneLoad(string sceneName)
    {
    }

    [Token(Token = "0x600540E")]
    [Address(RVA = "0x1288530", Offset = "0x1287330", VA = "0x11288530")]
    private IEnumerator LoadLevelAsync() => (IEnumerator) null;

    [Token(Token = "0x600540F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_LoadScene()
    {
    }

    [Token(Token = "0x2001420")]
    public enum SceneTypes
    {
      [Token(Token = "0x4004A7A")] Additive,
      [Token(Token = "0x4004A7B")] HomeTown,
      [Token(Token = "0x4004A7C")] Replace,
      [Token(Token = "0x4004A7D")] BootScene,
    }
  }
}
