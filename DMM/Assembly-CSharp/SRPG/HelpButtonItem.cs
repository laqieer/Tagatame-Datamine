// Decompiled with JetBrains decompiler
// Type: SRPG.HelpButtonItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002617")]
  [AddComponentMenu("UI/HelpButtonItem")]
  public class HelpButtonItem : MonoBehaviour
  {
    [Token(Token = "0x400B167")]
    [FieldOffset(Offset = "0xC")]
    public GameObject HelpMainTemplate;
    [Token(Token = "0x400B168")]
    [FieldOffset(Offset = "0x10")]
    public GameObject m_MainWindowBase;
    [Token(Token = "0x400B169")]
    [FieldOffset(Offset = "0x14")]
    public GameObject m_HelpMain;

    [Token(Token = "0x600A9D9")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A9DA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A9DB")]
    [Address(RVA = "0x6D19D0", Offset = "0x6D07D0", VA = "0x106D19D0")]
    private void UpdateParam(int Idx)
    {
    }

    [Token(Token = "0x600A9DC")]
    [Address(RVA = "0x6D1890", Offset = "0x6D0690", VA = "0x106D1890")]
    private void OnSelectMenu(int MenuID)
    {
    }

    [Token(Token = "0x600A9DD")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public HelpButtonItem()
    {
    }
  }
}
