// Decompiled with JetBrains decompiler
// Type: SRPG.AdventureHomeButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F9B")]
  [AddComponentMenu("UI/Adventure/AdventureHomeButton")]
  public class AdventureHomeButton : MonoBehaviour
  {
    [Token(Token = "0x4008590")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject Badge;
    [Token(Token = "0x4008591")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject Button;
    [Token(Token = "0x4008592")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsUpdateCheck;
    [Token(Token = "0x4008593")]
    [FieldOffset(Offset = "0x18")]
    private int mPrefslog;

    [Token(Token = "0x60081DD")]
    [Address(RVA = "0x423560", Offset = "0x422360", VA = "0x10423560")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60081DE")]
    [Address(RVA = "0x423700", Offset = "0x422500", VA = "0x10423700")]
    private void Update()
    {
    }

    [Token(Token = "0x60081DF")]
    [Address(RVA = "0x423470", Offset = "0x422270", VA = "0x10423470")]
    private void DisplayBadge()
    {
    }

    [Token(Token = "0x60081E0")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AdventureHomeButton()
    {
    }
  }
}
