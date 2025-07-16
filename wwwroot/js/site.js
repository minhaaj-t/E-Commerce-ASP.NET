// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
document.addEventListener('DOMContentLoaded', function () {
    var quickViewModal = document.getElementById('quickViewModal');
    if (quickViewModal) {
        document.querySelectorAll('.product-card .btn-outline-primary[data-bs-toggle="modal"]').forEach(function (btn) {
            btn.addEventListener('click', function (e) {
                var card = btn.closest('.product-card');
                if (!card) return;
                var name = card.getAttribute('data-product-name');
                var price = card.getAttribute('data-product-price');
                var image = card.getAttribute('data-product-image');
                var desc = card.getAttribute('data-product-description');
                var rating = card.getAttribute('data-product-rating');
                var reviews = card.getAttribute('data-product-reviews');
                // Populate modal
                quickViewModal.querySelector('.modal-title').textContent = name;
                quickViewModal.querySelector('.quickview-img').src = image;
                quickViewModal.querySelector('.quickview-img').alt = name;
                quickViewModal.querySelector('.quickview-price').textContent = price;
                quickViewModal.querySelector('.quickview-desc').textContent = desc;
                let stars = '';
                for (let i = 0; i < 5; i++) stars += i < rating ? '★' : '☆';
                quickViewModal.querySelector('.quickview-rating').textContent = stars + ' (' + reviews + ' reviews)';
            });
        });
    }
});
