// Decompiled with JetBrains decompiler
// Type: PointQuestMissionItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002C6")]
public class PointQuestMissionItem : MonoBehaviour
{
  [Token(Token = "0x4000B7D")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private GameObject AchievementObj;
  [Token(Token = "0x4000B7E")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private GameObject StarObj;
  [Token(Token = "0x4000B7F")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private Text MissionText;
  [Token(Token = "0x4000B80")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private Text PointText;

  [Token(Token = "0x6000E7B")]
  [Address(RVA = "0x11D61A0", Offset = "0x11D4FA0", VA = "0x111D61A0")]
  public void SetUp(
    bool _is_clear,
    string _mission_text,
    string _point_text,
    bool _is_achievement_disp)
  {
  }

  [Token(Token = "0x6000E7C")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public PointQuestMissionItem()
  {
  }
}
