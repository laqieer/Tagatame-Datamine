// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AppGuardGetUniqueClientID
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001365")]
  [FlowNode.Pin(22, "GameGuard初期化失敗（接続や空き容量不足など）", FlowNode.PinTypes.Output, 22)]
  [AddComponentMenu("")]
  [FlowNode.Pin(21, "GameGuard初期化失敗（汎用）", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(20, "GameGuard初期化失敗（二重起動）", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(100, "Finish", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(10, "Start", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("AppGuard/GetUniqueClientID", 32741)]
  public class FlowNode_AppGuardGetUniqueClientID : FlowNode_Network
  {
    [Token(Token = "0x400479E")]
    private const int PIN_INPUT_START = 10;
    [Token(Token = "0x400479F")]
    private const int PIN_OUTPUT_FINISH = 100;
    [Token(Token = "0x40047A0")]
    private const int PIN_OUTPUT_GAMEGUARD_ALREADY_RUNNING = 20;
    [Token(Token = "0x40047A1")]
    private const int PIN_OUTPUT_GAMEGUARD_INIT_FAILED = 21;
    [Token(Token = "0x40047A2")]
    private const int PIN_OUTPUT_GAMEGUARD_ERROR_CONNECTION_SPACE = 22;

    [Token(Token = "0x6005163")]
    [Address(RVA = "0x1266590", Offset = "0x1265390", VA = "0x11266590", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005164")]
    [Address(RVA = "0x12665B0", Offset = "0x12653B0", VA = "0x112665B0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005165")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_AppGuardGetUniqueClientID()
    {
    }

    [Token(Token = "0x2001366")]
    private class Json_AppGuardClientID
    {
      [Token(Token = "0x40047A3")]
      [FieldOffset(Offset = "0x8")]
      public string unique_client_id;

      [Token(Token = "0x6005166")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_AppGuardClientID()
      {
      }
    }
  }
}
