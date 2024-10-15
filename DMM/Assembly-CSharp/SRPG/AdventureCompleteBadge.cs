// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureCompleteBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F7A")]
  [AddComponentMenu("UI/Adventure/AdventureCompleteBadge")]
  public class AdventureCompleteBadge : MonoBehaviour
  {
    [Token(Token = "0x40084FA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject BadgeOfComlete;
    [Token(Token = "0x40084FB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject AdvDataObject;

    [Token(Token = "0x600815D")]
    [Address(RVA = "0x41E340", Offset = "0x41D140", VA = "0x1041E340")]
    private void Start()
    {
    }

    [Token(Token = "0x600815E")]
    [Address(RVA = "0x41E3A0", Offset = "0x41D1A0", VA = "0x1041E3A0")]
    private void Update()
    {
    }

    [Token(Token = "0x600815F")]
    [Address(RVA = "0x41E2B0", Offset = "0x41D0B0", VA = "0x1041E2B0")]
    private bool IsComlete() => new bool();

    [Token(Token = "0x6008160")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureCompleteBadge()
    {
    }
  }
}
