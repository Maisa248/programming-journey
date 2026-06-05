const stores = {
  elektronik: [
    { name: "Tablet Apple ipad", price: 20499000, image: "https://i.pinimg.com/736x/69/f8/66/69f8664eb54f1d01d8f62e695f7585e7.jpg" },
    { name: "Gitar Listrik", price: 2742000, image: "https://i.pinimg.com/736x/8b/16/3e/8b163eddc304ee8f319ca27b468b5151.jpg" },
    { name: "Kuromi airpod case", price: 120000, image: "https://i.pinimg.com/1200x/2b/3b/51/2b3b51a12bcc0ade5cece9eaf3eb9239.jpg" },
    { name: "Digital camera aesthetic", price: 500000, image: "https://i.pinimg.com/736x/94/9d/2c/949d2c3551eec87ace473d70625036c1.jpg" },
    { name: "Pink! Galaxy s23! ", price: 19999000, image: "https://i.pinimg.com/736x/a3/db/80/a3db807e38c44378b57895ac207dcc57.jpg" },
    { name: "Headphone wireless pink", price: 250000, image: "https://i.pinimg.com/736x/61/1f/7c/611f7c19141def9f661dc0e113636f01.jpg" },
    { name: "Kulkas mini", price: 1800000, image: "https://i.pinimg.com/736x/d3/72/46/d372468212a9e9a18aed171a38357a9a.jpg" },
    { name: "Kipas angin portabel", price: 90000, image: "https://i.pinimg.com/1200x/cc/56/e5/cc56e5991c8338ecbc27086d6e809b6c.jpg" },
    { name: "Kuromi Sofa Night Lamp 💜", price: 120000, image: "https://i.pinimg.com/1200x/5c/bf/d5/5cbfd598a801e9a0fe02e10c8f7355c4.jpg" }
  ],
  boneka: [
    { name: "Boneka Putri Lolita", price: 175000, image: "https://i.pinimg.com/736x/3f/d5/3d/3fd53df083d37b3382fdfafe0ba1a2b7.jpg" },
    { name: "Boneka Dracin", price: 100000, image: "https://i.pinimg.com/736x/df/63/bd/df63bdb256dcdba2523100a7905f1adf.jpg" },
    { name: "Contton Doll", price: 155000, image: "https://i.pinimg.com/736x/47/0b/3a/470b3a4986430cffd663099730574b71.jpg" },
    { name: "Lotso", price: 225000, image: "https://i.pinimg.com/736x/0f/a5/74/0fa5744b613a9e9c229c91ca7f6e848b.jpg" },
    { name: "Kuromi", price: 55000, image: "https://i.pinimg.com/736x/5c/92/b6/5c92b6e099673afb0a04e2291902a4e4.jpg" },
    { name: "Kitty Rwar", price: 55000, image: "https://i.pinimg.com/1200x/38/7b/4d/387b4d3f3cf8cd602075875ca4dc21b1.jpg" },
    { name: "Kecoa🥵", price: 315000, image: "https://i.pinimg.com/736x/19/ba/61/19ba612415dd080f52e2512954e35967.jpg" },
    { name: "Nailong", price: 205000, image: "https://i.pinimg.com/1200x/42/d8/bb/42d8bb3b8e81074746b467adfd1a351f.jpg" },
    { name: "Kuromi & Cinamorol rwar", price: 530000, image: "https://i.pinimg.com/736x/45/c1/de/45c1de196a4487fd7c2742303b6c0f54.jpg" }
  ],
  makanan: [
    { name: "Pancake", price: 25000, image: "https://i.pinimg.com/1200x/47/e2/93/47e2938af967067d00d30a439ef62fb3.jpg" },
    { name: "Dimsum Mentai", price: 15000, image: "https://i.pinimg.com/736x/cc/93/79/cc9379e2e128a90a47f9754bae786fcf.jpg" },
    { name: "Burger Super", price: 28000, image: "https://i.pinimg.com/736x/eb/cb/c6/ebcbc6aaa9deca9d6efc1efc93b66945.jpg" },
    { name: "Seblak Happy", price: 60000, image: "https://i.pinimg.com/736x/c2/eb/ab/c2ebab504458b984febfc04585830e97.jpg" },
    { name: "Pentol Julit", price: 45000, image: "https://i.pinimg.com/736x/32/01/d9/3201d98e927b557c4d38affa965bfca7.jpg" },
    { name: "Macha Ori", price: 55000, image: "https://i.pinimg.com/736x/06/5d/8e/065d8ecf759a5ba32582029777f5f4cf.jpg" },
    { name: "Strawberry Nyami", price: 31000, image: "https://i.pinimg.com/736x/53/13/01/531301c7829d9d4e1ea13483254a6603.jpg" },
    { name: "Milo Super", price: 105000, image: "https://i.pinimg.com/1200x/65/dc/7e/65dc7e3d8b695e42708dc9cff874fef5.jpg" },
    { name: "Boba cake", price: 120000, image: "https://i.pinimg.com/1200x/d3/15/92/d31592c5f9ed97f564aa24bcad9f68e3.jpg" }
  ]
};

const storeDisplayNames = {
  elektronik: "Elektronik",
  boneka: "Boneka",
  makanan: "Makanan"
};

let cart = JSON.parse(localStorage.getItem("cart") || "[]");
let total = cart.reduce((sum, item) => sum + item.price, 0);

// Tampilkan notifikasi
function showNotification(message, type = 'success') {
  const notification = document.getElementById("notification");
  if (!notification) return;
  
  notification.textContent = message;
  notification.className = `notification show ${type}`;
  
  setTimeout(() => {
    notification.classList.remove('show');
  }, 3000);
}

// Update badge keranjang
function updateCartBadge() {
  const badge = document.getElementById("cart");
  if (badge) {
    badge.innerText = `🛒 Keranjang (${cart.length})`;
  }
}

function addToCart(name, price, image) {
  cart.push({ name, price, image });
  total += price;
  localStorage.setItem("cart", JSON.stringify(cart));
  updateCartBadge();
  renderCart();
  showNotification(`✓ ${name} ditambahkan ke keranjang!`, 'success');
}

// Render produk toko
function renderStore(storeName) {
  const container = document.getElementById("store-items");
  if (!container) return;
  container.innerHTML = "";

  stores[storeName].forEach(product => {
    const card = document.createElement("div");
    card.className = "product-card";

    const img = document.createElement("img");
    img.src = product.image;
    img.alt = product.name;
    img.loading = "lazy";
    img.onerror = function() {
      this.src = "https://via.placeholder.com/280x180?text=No+Image";
    };
    card.appendChild(img);

    const h3 = document.createElement("h3");
    h3.textContent = product.name;
    card.appendChild(h3);

    const p = document.createElement("p");
    p.textContent = `Rp ${product.price.toLocaleString("id-ID")}`;
    card.appendChild(p);

    const button = document.createElement("button");
    button.textContent = "Tambah ke Keranjang";
    button.onclick = () => addToCart(product.name, product.price, product.image);
    card.appendChild(button);

    container.appendChild(card);
  });
}

// Render isi keranjang
function renderCart() {
  const cartItems = document.getElementById("cart-items");
  const totalElement = document.getElementById("total");
  if (!cartItems || !totalElement) return;

  cartItems.innerHTML = "";
  if (cart.length === 0) {
    cartItems.innerHTML = "<p>Keranjang kosong. Silakan tambahkan produk terlebih dahulu.</p>";
    totalElement.innerText = "0";
    return;
  }

  cart.forEach(item => {
    const li = document.createElement("li");
    li.textContent = `${item.name} - Rp ${item.price.toLocaleString("id-ID")}`;
    cartItems.appendChild(li);
  });

  totalElement.innerText = total.toLocaleString("id-ID");
}

// Ambil nama toko dari URL
function getStoreNameFromUrl() {
  const params = new URLSearchParams(window.location.search);
  return params.get("store");
}

// Inisialisasi halaman
function initPage() {
  updateCartBadge();
  renderCart();
  let storeName = getStoreNameFromUrl();
  const storeTitle = document.getElementById("store-name");
  const storeContainer = document.getElementById("store-items");

  if (!storeName || !stores[storeName]) {
    storeName = "elektronik"; // default
    if (storeTitle) storeTitle.textContent = "Toko Elektronik";
    if (storeContainer) {
      storeContainer.innerHTML = `
        <p>Menampilkan produk elektronik sebagai default. Pilih kategori lain dari halaman <a href="products.html">produk</a>.</p>
      `;
    }
  } else {
    if (storeTitle) storeTitle.textContent = `Toko ${storeDisplayNames[storeName]}`;
    if (storeContainer) storeContainer.innerHTML = "";
  }

  renderStore(storeName);
}

document.addEventListener("DOMContentLoaded", initPage);
