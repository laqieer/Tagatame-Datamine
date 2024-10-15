// Decompiled with JetBrains decompiler
// Type: SRPG.RuneStorageAddWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029F5")]
  [AddComponentMenu("UI/Rune/RuneStorageAddWindow")]
  public class RuneStorageAddWindow : MonoBehaviour
  {
    [Token(Token = "0x400CBD6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_BeforeStorageSize;
    [Token(Token = "0x400CBD7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text m_AfterStorageSize;
    [Token(Token = "0x400CBD8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text m_Message;

    [Token(Token = "0x600BF40")]
    [Address(RVA = "0x867EA0", Offset = "0x866CA0", VA = "0x10867EA0")]
    private void Start()
    {
    }

    [Token(Token = "0x600BF41")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public RuneStorageAddWindow()
    {
    }
  }
}
