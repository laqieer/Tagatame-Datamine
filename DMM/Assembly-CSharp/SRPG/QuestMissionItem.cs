// Decompiled with JetBrains decompiler
// Type: SRPG.QuestMissionItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20028AC")]
  [AddComponentMenu("UI/QuestMissionItem")]
  public class QuestMissionItem : MonoBehaviour
  {
    [Token(Token = "0x400C2B1")]
    [FieldOffset(Offset = "0xC")]
    public GameParameter Star;
    [Token(Token = "0x400C2B2")]
    [FieldOffset(Offset = "0x10")]
    public GameParameter FrameParam;
    [Token(Token = "0x400C2B3")]
    [FieldOffset(Offset = "0x14")]
    public GameParameter IconParam;
    [Token(Token = "0x400C2B4")]
    [FieldOffset(Offset = "0x18")]
    public GameParameter NameParam;
    [Token(Token = "0x400C2B5")]
    [FieldOffset(Offset = "0x1C")]
    public GameParameter AmountParam;
    [Token(Token = "0x400C2B6")]
    [FieldOffset(Offset = "0x20")]
    public GameParameter ObjectigveParam;
    [Token(Token = "0x400C2B7")]
    [FieldOffset(Offset = "0x24")]
    public GameParameter ProgressBadgeParam;
    [Token(Token = "0x400C2B8")]
    [FieldOffset(Offset = "0x28")]
    public GameParameter ProgressCurrentParam;
    [Token(Token = "0x400C2B9")]
    [FieldOffset(Offset = "0x2C")]
    public GameParameter ProgressTargetParam;

    [Token(Token = "0x600B7D6")]
    [Address(RVA = "0x7EA510", Offset = "0x7E9310", VA = "0x107EA510")]
    public void SetGameParameterIndex(int index)
    {
    }

    [Token(Token = "0x600B7D7")]
    [Address(RVA = "0x7EA4B0", Offset = "0x7E92B0", VA = "0x107EA4B0")]
    private void InternalSetGameParameterIndex(GameParameter target, int index)
    {
    }

    [Token(Token = "0x600B7D8")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public QuestMissionItem()
    {
    }
  }
}
