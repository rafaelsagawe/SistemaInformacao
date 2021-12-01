const dragStart = event => {
    event.currentTarget.classList.add('dragging');
};

const dragEnd = event => {
    event.currentTarget.classList.remove('dragging');
};

document.querySelectorAll('.card').forEach(card => {
    card.addEventListener('dragstart', dragStart);
    card.addEventListener('dragend', dragEnd);
});

// https://www.webtips.dev/how-to-create-native-drag-and-drop-functionality-in-javascript