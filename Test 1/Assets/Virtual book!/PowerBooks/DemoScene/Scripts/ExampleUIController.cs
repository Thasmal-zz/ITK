using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TLGFPowerBooks;

public class ExampleUIController : MonoBehaviour {

	public PBook pBook;
	

	public void OpenBook () {
		pBook.OpenBook ();
	}

	public void CloseBook () {
		pBook.CloseBook ();
	}

	public void NextPage () {
		pBook.NextPage ();
	}

	public void PrevPage () {
		pBook.PrevPage ();
	}

	public void GoToLastPage () {
		pBook.GoToLastPage (50);
	}

	public void GoToFirstPage () {
		pBook.GoToFirstPage (50);
	}

	public void JumpToLastPage () {
		pBook.JumpToLastPage (true);
	}
    
    public void JumpToPage (int h) {
        pBook.JumpToPage (h,true);
    }
    
    public void GoToPage (int h) {
        pBook.GoToPage (h,10);
    }

	public void JumpToFirstPage () {
		pBook.JumpToFirstPage (true);
	}
}
