Public Interface ISwipeForm

    Sub Swipe(show As Boolean, Optional enabled As Boolean = True)
    Sub Refresh()
    ReadOnly Property Visible As Boolean

End Interface
