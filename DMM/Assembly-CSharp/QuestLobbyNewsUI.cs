// Decompiled with JetBrains decompiler
// Type: QuestLobbyNewsUI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000235")]
[AddComponentMenu("Flow/Nodes/QuestLobbyNewsUI")]
public class QuestLobbyNewsUI : MonoBehaviour
{
  [Token(Token = "0x4000980")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private QuestLobbyNews.QuestLobbyCategory mCategory;
  [Token(Token = "0x4000981")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private GameObject mBadgeRoot;
  [Token(Token = "0x4000982")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private Text mText;

  [Token(Token = "0x6000BC4")]
  [Address(RVA = "0x1089BD0", Offset = "0x10889D0", VA = "0x11089BD0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000BC5")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public QuestLobbyNewsUI()
  {
  }
}
